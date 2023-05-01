using System;
using System.Drawing;

namespace GraphicEx
{
    public class ElipseShape : Shape, IFillable
    {
        
        private bool fill = false;
        public ElipseShape(Graphics graphics, bool fill = false) : base(graphics)
        {
            setFill(fill);
        }

        public override void Draw()
        {
            if (fill) graphics.FillEllipse(tools.brush, bounds);
            graphics.DrawEllipse(tools.pen, bounds);
        }

        public override void finishDraw()
        {
            path.AddEllipse(bounds);
        }


        public void setFill(bool fill)
        {
            this.fill = fill;
        }
    }
}