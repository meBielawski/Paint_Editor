using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PaintEditor
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;
        private bool _isDrawing = false;
        private Point _startPoint;
        private Point _currentPoint;
        private Point _endPoint;
        private int _x, _y;
        private Point RectStartPoint;
        private Rectangle _selectRect = new Rectangle();
        private Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));
        private bool _isMovingSelectedArea = false;
        private Point _initialMoveLocation = Point.Empty;
        private Bitmap? _selectedArea;
        public List<LineSegment> LineSegments = new List<LineSegment>();
        public List<LineSegment> TempSegments = new List<LineSegment>();
        public List<TreeNode> TreeNodes = new List<TreeNode>();
        public List<ShapeDetails> Shapes = new List<ShapeDetails>();
        private Stack<Bitmap> _undo = new Stack<Bitmap>();
        private Stack<Bitmap> _redo = new Stack<Bitmap>();
        private Color _markerColor = Color.Black;
        private Color _strokeColor = Color.Black;
        private bool _fillEnabled = false;
        private Color _fillColor = Color.Blue;
        private int _markerSize = 10;
        private int _strokeThickness = 10;

        public ModeSelection ModeSelection { get; } = new();
        public ShapeSelection ShapeSelection { get; } = new();
        public Bitmap Bitmap => _bitmap;


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            UpdatePanels();

            DoubleBuffered = true;
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            InitializeContextMenu();

            _fillColor = fillColorDialog.Color;
            fillColorDialog.Color = Color.Black;
            outlineColorDialog.Color = Color.Black;
            markerColorDialog.Color = Color.Black;

            ModeSelection.ModeChanged += ModeSelectionWhenChanged;
            ModeSelection.Mode = Mode.Initial;

            ShapeSelection.TypeChanged += ShapeSelectionWhenChanged;
            ShapeSelection.Type = ShapeType.Initial;
        }

        private void InitializeContextMenu()
        {
            if (ModeSelection.Mode == Mode.Select)
            {
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                ToolStripMenuItem moveItem = new ToolStripMenuItem("Transform");
                moveItem.Click += MoveItem_Click;
                contextMenu.Items.Add(moveItem);
                ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");
                deleteItem.Click += DeleteItem_Click;
                contextMenu.Items.Add(deleteItem);
                pictureBox1.ContextMenuStrip = contextMenu;
            }
        }

        private void UpdatePanels()
        {
            fillColorPanel.BackColor = fillColorDialog.Color;
            outlineColorPanel.BackColor = outlineColorDialog.Color;
            markerColorPanel.BackColor = markerColorDialog.Color;
            if (ModeSelection.Mode == Mode.DrawShape)
            {
                markerLabel.Text = _strokeThickness.ToString();
            }

            if (ModeSelection.Mode == Mode.FreeDraw)
            {
                markerLabel.Text = _markerSize.ToString();
            }

        }

        //----------------------------------------------------------------------------------------------------------------
        //Picture Box Handelling------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (ModeSelection.Mode == Mode.Select)
            {
                if (_selectRect.Width > 0 && _selectRect.Height > 0)
                {
                    g.FillRectangle(selectionBrush, _selectRect);
                }

                if (pictureBox1.Image != null)
                {
                    if (_isMovingSelectedArea)
                    {
                        if (_selectedArea != null)
                        {
                            g.DrawImage(_selectedArea, _selectRect);
                        }

                        using (Pen selectionPen = new Pen(Color.Black, 1))
                        {
                            selectionPen.DashStyle = DashStyle.Dot;
                            g.DrawRectangle(selectionPen, _selectRect);
                        }
                    }
                    else if (_selectRect.Width > 0 && _selectRect.Height > 0)
                    {
                        g.FillRectangle(selectionBrush, _selectRect);
                    }
                }
            }

            if (ModeSelection.Mode == Mode.FreeDraw)
            {
                if (_isDrawing)
                {
                    g.DrawImage(_bitmap, Point.Empty);
                }
            }

            if (ModeSelection.Mode == Mode.DrawShape)
            {
                if (_isDrawing)
                {
                    using var shapePen = new Pen(_strokeColor, _strokeThickness);
                    using var shapeBrush = new SolidBrush(_fillColor);
                    if (ShapeSelection.Type == ShapeType.Ellipse)
                    {
                        if (_fillEnabled)
                        {
                            g.FillEllipse(shapeBrush, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                        }

                        g.DrawEllipse(shapePen, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                    }

                    if (ShapeSelection.Type == ShapeType.Rectangle)
                    {
                        if (_fillEnabled)
                        {
                            g.FillRectangle(shapeBrush, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                        }

                        g.DrawRectangle(shapePen, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModeSelection.Mode == Mode.Select)
            {
                _isDrawing = true;
                RectStartPoint = e.Location;
                //Invalidate();
            }

            if (ModeSelection.Mode == Mode.FreeDraw || ModeSelection.Mode == Mode.Eraser)
            {
                _isDrawing = true;
                _endPoint = e.Location;
            }

            else if (ModeSelection.Mode == Mode.DrawShape && ShapeSelection.Type != ShapeType.Initial)
            {
                _isDrawing = true;
                _startPoint = _endPoint = e.Location;
                _currentPoint.X = e.X;
                _currentPoint.Y = e.Y;

            }

            if (e.Button == MouseButtons.Right)
            {
                _isDrawing = false;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                if (ModeSelection.Mode == Mode.Select)
                {
                    Point tempEndPoint = e.Location;
                    _selectRect.Location = new Point(
                    Math.Min(RectStartPoint.X, tempEndPoint.X),
                    Math.Min(RectStartPoint.Y, tempEndPoint.Y));
                    _selectRect.Size = new Size(
                    Math.Abs(RectStartPoint.X - tempEndPoint.X),
                    Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
                    pictureBox1.Invalidate();

                    if (_isMovingSelectedArea)
                    {
                        Point currentLocation = e.Location;
                        int dx = currentLocation.X - _initialMoveLocation.X;
                        int dy = currentLocation.Y - _initialMoveLocation.Y;
                        _selectRect.Offset(dx, dy);
                        _initialMoveLocation = currentLocation;
                        pictureBox1.Invalidate();
                    }
                }

                if ((ModeSelection.Mode == Mode.FreeDraw || ModeSelection.Mode == Mode.Eraser) && e.Button == MouseButtons.Left)
                {
                    using (Graphics g = Graphics.FromImage(_bitmap))
                    {
                        using (Pen pen = new Pen(_markerColor, _markerSize)
                        {
                            LineJoin = System.Drawing.Drawing2D.LineJoin.Round,
                            StartCap = System.Drawing.Drawing2D.LineCap.Round,
                            EndCap = System.Drawing.Drawing2D.LineCap.Round
                        })
                        {
                            (_startPoint, _endPoint) = (_endPoint, e.Location); //THANK YOU ANTOINE, EXTRA 5% FOR THE MAN, HE DESERVES IT
                            _endPoint = e.Location;
                            g.DrawLine(pen, _startPoint, _endPoint);
                            if (ModeSelection.Mode == Mode.FreeDraw)
                            {
                                LineSegment lineSegment = new LineSegment(_startPoint, _endPoint);
                                TempSegments.Add(lineSegment);
                            }
                        }
                    }
                    _startPoint = e.Location;
                    pictureBox1.Image = _bitmap;
                    pictureBox1.Refresh();
                }

                _x = e.X;
                _y = e.Y;
                _startPoint.X = e.X - _currentPoint.X;
                _startPoint.Y = e.Y - _currentPoint.Y;

                if (ModeSelection.Mode != Mode.Initial)
                {
                    toolStripStatusLabel1.Text = " Pos: " + e.X + "," + e.Y;
                }

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDrawing = false;

            if (ModeSelection.Mode == Mode.Select)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (_isMovingSelectedArea)
                    {
                        FinalizeMove();
                    }
                }
                else if (e.Button == MouseButtons.Right && ModeSelection.Mode == Mode.Select)
                {
                    if (_selectRect.Contains(e.Location))
                    {
                        InitializeContextMenu();
                        pictureBox1.ContextMenuStrip.Show(pictureBox1, e.Location);
                    }
                }
            }

            if (ModeSelection.Mode == Mode.FreeDraw)
            {
                if (TempSegments.Count > 0)
                {
                    Point firstSegmentStart = TempSegments.First().Start;
                    Point lastSegmentEnd = TempSegments.Last().End;
                    LineSegment mergedSegment = new LineSegment(firstSegmentStart, lastSegmentEnd);
                    LineSegments.Add(mergedSegment);
                    UpdateItemList_Lines();
                    TempSegments.Clear();
                }

                _undo.Push(new Bitmap(_bitmap));
                _redo.Clear();
            }

            if (ModeSelection.Mode == Mode.DrawShape)
            {
                _startPoint.X = _x - _currentPoint.X;
                _startPoint.Y = _y - _currentPoint.Y;

                using var shapePen = new Pen(_strokeColor, _strokeThickness);
                using var shapeBrush = new SolidBrush(_fillColor);
                if (ShapeSelection.Type == ShapeType.Ellipse)
                {
                    using (Graphics g = Graphics.FromImage(_bitmap))
                    {
                        if (_fillEnabled)
                        {
                            g.FillEllipse(shapeBrush, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                        }
                        g.DrawEllipse(shapePen, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                    }

                    Shapes.Add(new ShapeDetails ()
                    {
                        X = _currentPoint.X,
                        Y = _currentPoint.Y,
                        Width = _startPoint.X,
                        Height = _startPoint.Y,
                        StrokeColor = outlineColorDialog.Color,
                        FillColor = fillColorDialog.Color,
                        Filled = fillEnabledToolStripMenuItem.Checked,
                        StrokeThickness = _strokeThickness,
                        Type =  ShapeType.Ellipse
                    });

                    UpdateItemList_Shapes();
                    _undo.Push(new Bitmap(_bitmap));
                    _redo.Clear();
                }

                if (ShapeSelection.Type == ShapeType.Rectangle)
                {
                    using (Graphics g = Graphics.FromImage(_bitmap))
                    {
                        if (_fillEnabled)
                        {
                            g.FillRectangle(shapeBrush, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                        }
                        g.DrawRectangle(shapePen, _currentPoint.X, _currentPoint.Y, _startPoint.X, _startPoint.Y);
                    }

                    Shapes.Add(new ShapeDetails()
                    {
                        X = _currentPoint.X,
                        Y = _currentPoint.Y,
                        Width = _startPoint.X,
                        Height = _startPoint.Y,
                        StrokeColor = outlineColorDialog.Color,
                        FillColor = fillColorDialog.Color,
                        Filled = fillEnabledToolStripMenuItem.Checked,
                        StrokeThickness = _strokeThickness,
                        Type = ShapeType.Rectangle
                    });

                    UpdateItemList_Shapes();
                    _undo.Push(new Bitmap(_bitmap));
                    _redo.Clear();
                }

                pictureBox1.Image = _bitmap;
                pictureBox1.Invalidate();
            }
        }
        //----------------------------------------------------------------------------------------------------------------
        //File Menu Clickables -------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Creating a new drawing will discard any unsaved changes. Do you want to continue?", "New Drawing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(_bitmap))
                {
                    g.Clear(Color.White);
                }

                _undo.Clear();
                _redo.Clear();

                LineSegments.Clear();
                TreeNodes.Clear();
                Shapes.Clear();

                itemTreeView.Nodes.Clear();
                itemPropertyGrid.SelectedObject = null;

                pictureBox1.Image = _bitmap;
                pictureBox1.Invalidate();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            var file = new Bitmap(openFileDialog.FileName);
            _bitmap = file;
            pictureBox1.Image = _bitmap;
            pictureBox1.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Image";
            saveFileDialog1.Filter = "BMP files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string fileName = saveFileDialog1.FileName;
            _bitmap.Save(fileName);
        }

        private void exportToSVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToSvg exportToSvg = new ExportToSvg(pictureBox1, Bitmap);
            exportToSvg.ExportSvg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //----------------------------------------------------------------------------------------------------------------
        //Mode Menu Settings & Clickables --------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void ModeSelectionWhenChanged(object? sender, EventArgs e)
        {
            selectToolStripMenuItem.Checked = ModeSelection.Mode == Mode.Select;
            drawShapeToolStripMenuItem.Checked = ModeSelection.Mode == Mode.DrawShape;
            freeDrawToolStripMenuItem.Checked = ModeSelection.Mode == Mode.FreeDraw;
            eraserToolStripMenuItem.Checked = ModeSelection.Mode == Mode.Eraser;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeSelection.Mode = Mode.Select;
            pictureBox1.Cursor = Cursors.Hand;

        }

        private void drawShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeSelection.Mode = Mode.DrawShape;
            pictureBox1.Cursor = Cursors.Cross;
            label4.Text = "Outline Thickness:";
            UpdatePanels();

        }

        private void freeDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeSelection.Mode = Mode.FreeDraw;
            _markerColor = markerColorDialog.Color;
            pictureBox1.Cursor = Cursors.Cross;
            label4.Text = "Marker Thickness:";
            UpdatePanels();
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModeSelection.Mode = Mode.Eraser;
            _markerColor = Color.White;
            pictureBox1.Cursor = Cursors.Cross;
        }

        //----------------------------------------------------------------------------------------------------------------
        //Shape Selection Settings & Clickables --------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        public void ShapeRectangle()
        {
            ShapeSelection.Type = ShapeType.Rectangle;
            ModeSelection.Mode = Mode.DrawShape;
        }

        public void ShapeEllipse()
        {
            ShapeSelection.Type = ShapeType.Ellipse;
            ModeSelection.Mode = Mode.DrawShape;
        }

        private void fillEnabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fillEnabled = true;
        }

        private void ShapeSelectionWhenChanged(object? sender, EventArgs e)
        {
            rectangleToolStripMenuItem.Checked = ShapeSelection.Type == ShapeType.Rectangle;
            ellipseToolStripMenuItem.Checked = ShapeSelection.Type == ShapeType.Ellipse;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeRectangle();
            UpdatePanels();
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeEllipse();
            UpdatePanels();
        }

        //----------------------------------------------------------------------------------------------------------------
        //Edit menu Clickables -------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_undo.Count > 0)
            {
                _redo.Push(_undo.Pop());
                if (_undo.Count > 0)
                {
                    _bitmap = new Bitmap(_undo.Peek());
                }
                else if (_undo.Count == 0)
                {
                    _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                }
                pictureBox1.Image = _bitmap;
                pictureBox1.Invalidate();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_redo.Count > 0)
            {
                _undo.Push(new Bitmap(_bitmap));
                _bitmap = new Bitmap(_redo.Pop());
                pictureBox1.Image = _bitmap;
                pictureBox1.Refresh();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _undo.Push(new Bitmap(Bitmap));
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = _bitmap;
            pictureBox1.Refresh();
        }

        //----------------------------------------------------------------------------------------------------------------
        //ToolStrip Clickables -------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void fillColorToolStripButton_Click(object sender, EventArgs e)
        {
            fillColorDialog.ShowDialog();
            _fillColor = fillColorDialog.Color;
            UpdatePanels();
        }

        private void outlineColorToolStripButton_Click(object sender, EventArgs e)
        {
            outlineColorDialog.ShowDialog();
            _strokeColor = outlineColorDialog.Color;
            UpdatePanels();
        }

        private void markerColorToolStripButton_Click(object sender, EventArgs e)
        {
            markerColorDialog.ShowDialog();
            _markerColor = markerColorDialog.Color;
            UpdatePanels();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _markerSize = 1;
            UpdatePanels();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _markerSize = 5;
            UpdatePanels();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _markerSize = 10;
            UpdatePanels();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _markerSize = 20;
            UpdatePanels();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _markerSize = 40;
            UpdatePanels();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _strokeThickness = 1;
            UpdatePanels();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            _strokeThickness = 5;
            UpdatePanels();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _strokeThickness = 10;
            UpdatePanels();

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            _strokeThickness = 20;
            UpdatePanels();

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            _strokeThickness = 40;
            UpdatePanels();

        }

        private void rectangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShapeRectangle();
            UpdatePanels();

        }


        private void ellipseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShapeEllipse();
            UpdatePanels();

        }

        //----------------------------------------------------------------------------------------------------------------
        //Item Panel & Properties Panel ----------------------------------------------------------------------------------
        // Derived from Chirstopher Diggins "SvgEditor" program. ---------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        public void UpdateItemList_Lines()
        {
            var oldsel = itemTreeView.SelectedNode?.Name;
            itemTreeView.Nodes.Clear();

            TreeNodes.RemoveAll(node => node.Tag is LineSegment);

            foreach (LineSegment segment in LineSegments)
            {
                TreeNode node = new TreeNode
                {
                    Text = $"Start: {segment.Start}, End: {segment.End}",
                    Tag = segment
                };
              
                TreeNodes.Add(node);
            }

            foreach (TreeNode node in TreeNodes)
            {
                itemTreeView.Nodes.Add(node);
            }
            

            if (oldsel != null)
            {
                itemTreeView.SelectedNode = itemTreeView.Nodes[oldsel];
            }
        }

        public void UpdateItemList_Shapes()
        {
            var oldsel = itemTreeView.SelectedNode?.Name;
            itemTreeView.Nodes.Clear();

            TreeNodes.RemoveAll(node => node.Tag is ShapeDetails);

            foreach (ShapeDetails s in Shapes)
            {
                TreeNode node = new TreeNode
                {
                    Text = $"Shape: {s.Type}, Size: {s.Width} x {s.Height}",
                    Tag = s
                };

                TreeNodes.Add(node);
            }

            foreach (TreeNode node in TreeNodes)
            {
                itemTreeView.Nodes.Add(node);
            }

            if (oldsel != null)
            {
                itemTreeView.SelectedNode = itemTreeView.Nodes[oldsel];
            }
        }

        private void itemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            itemPropertyGrid.SelectedObject = null;
            var selected = itemTreeView.SelectedNode;
            if (selected == null)
                return;
            var elem = selected.Tag as object;
            if (elem == null)
                return;
            itemPropertyGrid.SelectedObject = elem;
        }
        //----------------------------------------------------------------------------------------------------------------
        //Help! ----------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some people aren't good at asking for help because they're so used to being 'The Helper.' Throughout their life they've experienced an unbalanced amount of give and take, so their instinct is usually 'I'll figure it out on my own'. The self-reliance is all they've ever known.", "May God Help You.");
        }

        //----------------------------------------------------------------------------------------------------------------
        //Select Functionallity ------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        private void MoveItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;

            if (bmp != null)
            {
                Rectangle clonedRect = new Rectangle(_selectRect.Location, _selectRect.Size);
                _selectedArea = bmp.Clone(clonedRect, bmp.PixelFormat);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;
                    using (Brush clearBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0)))
                    {
                        g.FillRectangle(clearBrush, _selectRect);
                    }
                }
                pictureBox1.Invalidate();
                _isMovingSelectedArea = true;
                _initialMoveLocation = pictureBox1.PointToClient(Cursor.Position);
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            if (bmp != null)
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    // Replace the selected area with a transparent color
                    g.CompositingMode = CompositingMode.SourceCopy;
                    using (Brush clearBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0)))
                    {
                        g.FillRectangle(clearBrush, _selectRect);
                    }
                }

                _selectRect.Width = 0;
                _selectRect.Height = 0;
                // Refresh the PictureBox to show the updated image
                pictureBox1.Invalidate();
            }
        }

        private void FinalizeMove()
        {
            if (_selectedArea != null)
            {
                Bitmap bmp = (Bitmap)pictureBox1.Image;

                if (bmp != null)
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(_selectedArea, _selectRect);
                    }

                    //pictureBox1.Image = bmp;
                }

                _selectedArea.Dispose();
                _selectedArea = null;
            }

            _selectRect.Width = 0;
            _selectRect.Height = 0;
            _isMovingSelectedArea = false;
            _initialMoveLocation = Point.Empty;
        }
    }
}