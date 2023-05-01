using System;
using System.Drawing;

namespace GraphicEx
{
    public class RectShape : Shape, IFillable
    {
        private bool fill = false;
        public RectShape(Graphics graphics, bool fill = false) : base(graphics)
        {
            setFill(fill);
        }

        public override void Draw()
        { 
            if (fill) graphics.FillRectangle(tools.brush, bounds);
            graphics.DrawRectangle(tools.pen, bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }

        public override void finishDraw()
        {
            path.AddRectangle(bounds);
        }

        public void setFill(bool fill)
        {
            this.fill = fill; 
        }
    }
}