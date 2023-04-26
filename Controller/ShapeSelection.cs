namespace PaintEditor
{
    public enum ShapeType
    {
        Initial,
        Rectangle,
        Ellipse
    }

    public class ShapeSelection
    {
        private ShapeType _type = ShapeType.Initial;
        public ShapeType Type
        {
            get => _type;
            set
            {
                _type = value;
                TypeChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler? TypeChanged;
    }

    public class ShapeDetails
    {
        public Color StrokeColor;
        public float StrokeThickness;
        public float X;
        public float Y;
        public float Width;
        public float Height;
        public Color FillColor;
        public bool Filled;
        public ShapeType Type;
    }
}