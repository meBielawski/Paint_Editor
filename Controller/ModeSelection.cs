using Microsoft.Win32;

namespace PaintEditor;

public enum Mode
{
    Initial,
    Select,
    DrawShape,
    FreeDraw,
    Eraser
}

public class ModeSelection
{
    private Mode _mode = Mode.Initial;
    public Mode Mode
    {
        get => _mode;
        set
        {
            _mode = value;
            ModeChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public event EventHandler? ModeChanged;
}