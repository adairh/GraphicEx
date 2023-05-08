using System;
using System.Drawing;

namespace GraphicEx
{
    public class CircleShape : Shape, IFillable
    {
        
        private bool fill = false;
        public CircleShape(Graphics graphics, bool fill = false) : base(graphics)
        {
            setFill(fill);
        }

        public override void generateBound()
        {
            bounds.X = started.X < ended.X ? started.X : ended.X;
            bounds.Y = started.Y < ended.Y ? started.Y : ended.Y;
            int a = Math.Abs(ended.X - started.X);
            int b = Math.Abs(ended.Y - started.Y);
            bounds.Width = Math.Max(a, b);
            bounds.Height = Math.Max(a, b);
            ended.X = (int)(bounds.X + bounds.Width);
            ended.Y = (int)(bounds.Y + bounds.Height);
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