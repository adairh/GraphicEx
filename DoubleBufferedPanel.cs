using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GraphicEx
{
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);    
            UpdateStyles();
        }
    }
}