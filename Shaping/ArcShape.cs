using System;
using System.Drawing;

namespace GraphicEx
{
    public class ArcShape : Shape
    {

        private float minAngle = 0.0F, maxAngle = 0.0F, totalAngle = 10;
        public ArcShape(Graphics graphics) : base(graphics)
        {
        }

        public override void Draw()
        {
            this.maxAngle = tools.data[0];
            bounds.Width = bounds.Width >= 1 ? bounds.Width : 1;
            bounds.Height = bounds.Height >= 1 ? bounds.Height : 1; 
            //graphics.RotateTransform(totalAngle);
            graphics.DrawArc(tools.pen, bounds, minAngle, maxAngle);
        }

        public override void finishDraw()
        {
            path.AddArc(bounds, minAngle, maxAngle);
        }
    }
}