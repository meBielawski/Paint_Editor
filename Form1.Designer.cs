namespace PaintEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exportToSVGToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clearToolStripMenuItem = new ToolStripMenuItem();
            modeToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            drawShapeToolStripMenuItem = new ToolStripMenuItem();
            freeDrawToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            eraserToolStripMenuItem = new ToolStripMenuItem();
            shapeSelectionToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator10 = new ToolStripSeparator();
            fillEnabledToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            itemTreeView = new TreeView();
            itemPropertyGrid = new PropertyGrid();
            tableLayoutPanel6 = new TableLayoutPanel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton2 = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator5 = new ToolStripSeparator();
            fillColorToolStripButton = new ToolStripButton();
            toolStripLabel3 = new ToolStripLabel();
            outlineColorToolStripButton = new ToolStripButton();
            toolStripLabel4 = new ToolStripLabel();
            markerColorToolStripButton = new ToolStripButton();
            toolStripLabel5 = new ToolStripLabel();
            toolStripSeparator6 = new ToolStripSeparator();
            brushWidthToolStripButton = new ToolStripDropDownButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripLabel6 = new ToolStripLabel();
            toolStripButton6 = new ToolStripDropDownButton();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            toolStripLabel11 = new ToolStripLabel();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripLabel7 = new ToolStripLabel();
            toolStripButton3 = new ToolStripDropDownButton();
            rectangleToolStripMenuItem1 = new ToolStripMenuItem();
            ellipseToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripLabel8 = new ToolStripLabel();
            toolStripButton4 = new ToolStripButton();
            toolStripLabel9 = new ToolStripLabel();
            toolStripButton5 = new ToolStripButton();
            toolStripLabel10 = new ToolStripLabel();
            tableLayoutPanel5 = new TableLayoutPanel();
            fillColorPanel = new Panel();
            outlineColorPanel = new Panel();
            markerColorPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            markerLabel = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fillColorDialog = new ColorDialog();
            outlineColorDialog = new ColorDialog();
            markerColorDialog = new ColorDialog();
            menuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            toolStrip1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, modeToolStripMenuItem, shapeSelectionToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1545, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator3, exportToSVGToolStripMenuItem, toolStripSeparator4, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(186, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(186, 22);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(186, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(183, 6);
            // 
            // exportToSVGToolStripMenuItem
            // 
            exportToSVGToolStripMenuItem.Name = "exportToSVGToolStripMenuItem";
            exportToSVGToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+E";
            exportToSVGToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportToSVGToolStripMenuItem.Size = new Size(186, 22);
            exportToSVGToolStripMenuItem.Text = "&Export to SVG";
            exportToSVGToolStripMenuItem.Click += exportToSVGToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(183, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(186, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator2, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+R";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(141, 6);
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clearToolStripMenuItem.Size = new Size(144, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectToolStripMenuItem, toolStripSeparator1, drawShapeToolStripMenuItem, freeDrawToolStripMenuItem, toolStripSeparator8, eraserToolStripMenuItem });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(50, 20);
            modeToolStripMenuItem.Text = "Mode";
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(136, 22);
            selectToolStripMenuItem.Text = "Select";
            selectToolStripMenuItem.Click += selectToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(133, 6);
            // 
            // drawShapeToolStripMenuItem
            // 
            drawShapeToolStripMenuItem.Name = "drawShapeToolStripMenuItem";
            drawShapeToolStripMenuItem.Size = new Size(136, 22);
            drawShapeToolStripMenuItem.Text = "Draw Shape";
            drawShapeToolStripMenuItem.Click += drawShapeToolStripMenuItem_Click;
            // 
            // freeDrawToolStripMenuItem
            // 
            freeDrawToolStripMenuItem.Name = "freeDrawToolStripMenuItem";
            freeDrawToolStripMenuItem.Size = new Size(136, 22);
            freeDrawToolStripMenuItem.Text = "Free Draw";
            freeDrawToolStripMenuItem.Click += freeDrawToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(133, 6);
            // 
            // eraserToolStripMenuItem
            // 
            eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            eraserToolStripMenuItem.Size = new Size(136, 22);
            eraserToolStripMenuItem.Text = "Eraser";
            eraserToolStripMenuItem.Click += eraserToolStripMenuItem_Click;
            // 
            // shapeSelectionToolStripMenuItem
            // 
            shapeSelectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem, ellipseToolStripMenuItem, toolStripSeparator10, fillEnabledToolStripMenuItem });
            shapeSelectionToolStripMenuItem.Name = "shapeSelectionToolStripMenuItem";
            shapeSelectionToolStripMenuItem.Size = new Size(102, 20);
            shapeSelectionToolStripMenuItem.Text = "Shape Selection";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(134, 22);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += rectangleToolStripMenuItem_Click;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(134, 22);
            ellipseToolStripMenuItem.Text = "Ellipse";
            ellipseToolStripMenuItem.Click += ellipseToolStripMenuItem_Click;
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(131, 6);
            // 
            // fillEnabledToolStripMenuItem
            // 
            fillEnabledToolStripMenuItem.CheckOnClick = true;
            fillEnabledToolStripMenuItem.Name = "fillEnabledToolStripMenuItem";
            fillEnabledToolStripMenuItem.Size = new Size(134, 22);
            fillEnabledToolStripMenuItem.Text = "Fill Enabled";
            fillEnabledToolStripMenuItem.Click += fillEnabledToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 20);
            helpToolStripMenuItem.Text = "Help?";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.74919F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2508125F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 52);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1539, 646);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(itemTreeView, 0, 0);
            tableLayoutPanel3.Controls.Add(itemPropertyGrid, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(1138, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2788467F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 75.72115F));
            tableLayoutPanel3.Size = new Size(398, 640);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // itemTreeView
            // 
            itemTreeView.Dock = DockStyle.Fill;
            itemTreeView.Location = new Point(3, 3);
            itemTreeView.Name = "itemTreeView";
            itemTreeView.Size = new Size(392, 149);
            itemTreeView.TabIndex = 0;
            itemTreeView.AfterSelect += itemTreeView_AfterSelect;
            // 
            // itemPropertyGrid
            // 
            itemPropertyGrid.Dock = DockStyle.Fill;
            itemPropertyGrid.Location = new Point(3, 158);
            itemPropertyGrid.Name = "itemPropertyGrid";
            itemPropertyGrid.Size = new Size(392, 479);
            itemPropertyGrid.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(statusStrip, 0, 1);
            tableLayoutPanel6.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 97.40741F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 2.59259248F));
            tableLayoutPanel6.Size = new Size(1129, 640);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // statusStrip
            // 
            statusStrip.Dock = DockStyle.Fill;
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 623);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1129, 17);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(89, 12);
            toolStripStatusLabel1.Text = "Mouse Position";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1123, 617);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.03125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.96875F));
            tableLayoutPanel1.Size = new Size(1545, 701);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.ControlLight;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.74919F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2508125F));
            tableLayoutPanel4.Controls.Add(toolStrip1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1539, 43);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.AppWorkspace;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1, toolStripButton2, toolStripLabel2, toolStripSeparator5, fillColorToolStripButton, toolStripLabel3, outlineColorToolStripButton, toolStripLabel4, markerColorToolStripButton, toolStripLabel5, toolStripSeparator6, brushWidthToolStripButton, toolStripLabel6, toolStripButton6, toolStripLabel11, toolStripSeparator7, toolStripButton7, toolStripLabel7, toolStripButton3, toolStripLabel8, toolStripButton4, toolStripLabel9, toolStripButton5, toolStripLabel10 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1135, 43);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 40);
            toolStripButton1.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(36, 40);
            toolStripLabel1.Text = "Undo";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 40);
            toolStripButton2.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(34, 40);
            toolStripLabel2.Text = "Redo";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 43);
            // 
            // fillColorToolStripButton
            // 
            fillColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            fillColorToolStripButton.Image = (Image)resources.GetObject("fillColorToolStripButton.Image");
            fillColorToolStripButton.ImageTransparentColor = Color.Magenta;
            fillColorToolStripButton.Name = "fillColorToolStripButton";
            fillColorToolStripButton.Size = new Size(23, 40);
            fillColorToolStripButton.Click += fillColorToolStripButton_Click;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(73, 40);
            toolStripLabel3.Text = "Set Fill Color";
            // 
            // outlineColorToolStripButton
            // 
            outlineColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            outlineColorToolStripButton.Image = (Image)resources.GetObject("outlineColorToolStripButton.Image");
            outlineColorToolStripButton.ImageTransparentColor = Color.Magenta;
            outlineColorToolStripButton.Name = "outlineColorToolStripButton";
            outlineColorToolStripButton.Size = new Size(23, 40);
            outlineColorToolStripButton.Click += outlineColorToolStripButton_Click;
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(97, 40);
            toolStripLabel4.Text = "Set Outline Color";
            // 
            // markerColorToolStripButton
            // 
            markerColorToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            markerColorToolStripButton.Image = (Image)resources.GetObject("markerColorToolStripButton.Image");
            markerColorToolStripButton.ImageTransparentColor = Color.Magenta;
            markerColorToolStripButton.Name = "markerColorToolStripButton";
            markerColorToolStripButton.Size = new Size(23, 40);
            markerColorToolStripButton.Click += markerColorToolStripButton_Click;
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(95, 40);
            toolStripLabel5.Text = "Set Marker Color";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 43);
            // 
            // brushWidthToolStripButton
            // 
            brushWidthToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            brushWidthToolStripButton.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            brushWidthToolStripButton.Image = (Image)resources.GetObject("brushWidthToolStripButton.Image");
            brushWidthToolStripButton.ImageTransparentColor = Color.Magenta;
            brushWidthToolStripButton.Name = "brushWidthToolStripButton";
            brushWidthToolStripButton.Size = new Size(29, 40);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(86, 22);
            toolStripMenuItem1.Text = "1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(86, 22);
            toolStripMenuItem2.Text = "5";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(86, 22);
            toolStripMenuItem3.Text = "10";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(86, 22);
            toolStripMenuItem4.Text = "20";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(86, 22);
            toolStripMenuItem5.Text = "40";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(117, 40);
            toolStripLabel6.Text = "Set Marker Thickness";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8, toolStripMenuItem9, toolStripMenuItem10, toolStripMenuItem11 });
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(29, 40);
            toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(86, 22);
            toolStripMenuItem7.Text = "1";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(86, 22);
            toolStripMenuItem8.Text = "5";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(86, 22);
            toolStripMenuItem9.Text = "10";
            toolStripMenuItem9.Click += toolStripMenuItem9_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(86, 22);
            toolStripMenuItem10.Text = "20";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(86, 22);
            toolStripMenuItem11.Text = "40";
            toolStripMenuItem11.Click += toolStripMenuItem11_Click;
            // 
            // toolStripLabel11
            // 
            toolStripLabel11.Name = "toolStripLabel11";
            toolStripLabel11.Size = new Size(154, 40);
            toolStripLabel11.Text = "Set Shape Outline Thickness";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 43);
            // 
            // toolStripButton7
            // 
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(23, 40);
            toolStripButton7.Click += selectToolStripMenuItem_Click;
            // 
            // toolStripLabel7
            // 
            toolStripLabel7.Name = "toolStripLabel7";
            toolStripLabel7.Size = new Size(38, 40);
            toolStripLabel7.Text = "Select";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.DropDownItems.AddRange(new ToolStripItem[] { rectangleToolStripMenuItem1, ellipseToolStripMenuItem1 });
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 40);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += drawShapeToolStripMenuItem_Click;
            // 
            // rectangleToolStripMenuItem1
            // 
            rectangleToolStripMenuItem1.Name = "rectangleToolStripMenuItem1";
            rectangleToolStripMenuItem1.Size = new Size(126, 22);
            rectangleToolStripMenuItem1.Text = "Rectangle";
            rectangleToolStripMenuItem1.Click += rectangleToolStripMenuItem1_Click;
            // 
            // ellipseToolStripMenuItem1
            // 
            ellipseToolStripMenuItem1.Name = "ellipseToolStripMenuItem1";
            ellipseToolStripMenuItem1.Size = new Size(126, 22);
            ellipseToolStripMenuItem1.Text = "Ellipse";
            ellipseToolStripMenuItem1.Click += ellipseToolStripMenuItem1_Click;
            // 
            // toolStripLabel8
            // 
            toolStripLabel8.Name = "toolStripLabel8";
            toolStripLabel8.Size = new Size(69, 40);
            toolStripLabel8.Text = "Draw Shape";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 40);
            toolStripButton4.Text = "toolStripButton4";
            toolStripButton4.Click += freeDrawToolStripMenuItem_Click;
            // 
            // toolStripLabel9
            // 
            toolStripLabel9.Name = "toolStripLabel9";
            toolStripLabel9.Size = new Size(59, 40);
            toolStripLabel9.Text = "Free Draw";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 40);
            toolStripButton5.Text = "toolStripButton5";
            toolStripButton5.Click += eraserToolStripMenuItem_Click;
            // 
            // toolStripLabel10
            // 
            toolStripLabel10.Name = "toolStripLabel10";
            toolStripLabel10.Size = new Size(38, 40);
            toolStripLabel10.Text = "Eraser";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoScroll = true;
            tableLayoutPanel5.BackColor = SystemColors.ControlLight;
            tableLayoutPanel5.ColumnCount = 8;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.952606F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.2938385F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.8767776F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.2938385F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.6398106F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.530806F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2985783F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5355453F));
            tableLayoutPanel5.Controls.Add(fillColorPanel, 1, 0);
            tableLayoutPanel5.Controls.Add(outlineColorPanel, 3, 0);
            tableLayoutPanel5.Controls.Add(markerColorPanel, 5, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 0);
            tableLayoutPanel5.Controls.Add(label2, 2, 0);
            tableLayoutPanel5.Controls.Add(label3, 4, 0);
            tableLayoutPanel5.Controls.Add(label4, 6, 0);
            tableLayoutPanel5.Controls.Add(markerLabel, 7, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(1138, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(398, 37);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // fillColorPanel
            // 
            fillColorPanel.Dock = DockStyle.Fill;
            fillColorPanel.Location = new Point(42, 3);
            fillColorPanel.Name = "fillColorPanel";
            fillColorPanel.Size = new Size(26, 31);
            fillColorPanel.TabIndex = 0;
            // 
            // outlineColorPanel
            // 
            outlineColorPanel.Dock = DockStyle.Fill;
            outlineColorPanel.Location = new Point(136, 3);
            outlineColorPanel.Name = "outlineColorPanel";
            outlineColorPanel.Size = new Size(26, 31);
            outlineColorPanel.TabIndex = 1;
            // 
            // markerColorPanel
            // 
            markerColorPanel.Dock = DockStyle.Fill;
            markerColorPanel.Location = new Point(229, 3);
            markerColorPanel.Name = "markerColorPanel";
            markerColorPanel.Size = new Size(27, 31);
            markerColorPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Fill :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(75, 11);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Outline : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(170, 11);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 6;
            label3.Text = " Marker : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(262, 3);
            label4.Name = "label4";
            label4.Size = new Size(61, 30);
            label4.TabIndex = 7;
            label4.Text = " Thickness:";
            // 
            // markerLabel
            // 
            markerLabel.Anchor = AnchorStyles.None;
            markerLabel.AutoSize = true;
            markerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            markerLabel.Location = new Point(362, 11);
            markerLabel.Name = "markerLabel";
            markerLabel.Size = new Size(0, 15);
            markerLabel.TabIndex = 8;
            markerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1545, 725);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Paint Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem shapeSelectionToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exportToSVGToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem drawShapeToolStripMenuItem;
        private ToolStripMenuItem freeDrawToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TreeView itemTreeView;
        private PropertyGrid itemPropertyGrid;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private ToolStrip toolStrip1;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel fillColorPanel;
        private Panel outlineColorPanel;
        private Panel markerColorPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label markerLabel;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton fillColorToolStripButton;
        private ToolStripLabel toolStripLabel3;
        private ToolStripButton outlineColorToolStripButton;
        private ToolStripLabel toolStripLabel4;
        private ToolStripButton markerColorToolStripButton;
        private ToolStripLabel toolStripLabel5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripLabel toolStripLabel6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton toolStripButton7;
        private ToolStripLabel toolStripLabel7;
        private ColorDialog fillColorDialog;
        private ColorDialog outlineColorDialog;
        private ColorDialog markerColorDialog;
        private ToolStripMenuItem eraserToolStripMenuItem;
        private ToolStripLabel toolStripLabel8;
        private ToolStripButton toolStripButton4;
        private ToolStripLabel toolStripLabel9;
        private ToolStripButton toolStripButton5;
        private ToolStripLabel toolStripLabel10;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripDropDownButton brushWidthToolStripButton;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem fillEnabledToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel6;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private ToolStripDropDownButton toolStripButton3;
        private ToolStripMenuItem rectangleToolStripMenuItem1;
        private ToolStripMenuItem ellipseToolStripMenuItem1;
        private ToolStripDropDownButton toolStripButton6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripLabel toolStripLabel11;
    }
}