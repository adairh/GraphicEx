using System;
using System.Drawing;

namespace GraphicEx
{
    public class PolygonShape : Shape, IFillable
    {
        private bool fill = false;
        private double radius;
        private Point p;
        private int no;
        private Point[] ps;
        private Point temp;
        public PolygonShape(Graphics graphics, bool fill = false) : base(graphics)
        {
            setFill(fill);
            temp = new Point();
        }

        public override void Draw()
        {
            
            no = (int)tools.data[0];
            ps = new Point[no];

            p.X = (int)bounds.X + (Math.Abs(ended.X - started.X))/2;
            p.Y = (int)bounds.Y + (Math.Abs(ended.Y - started.Y))/2;

            radius = Math.Min(Math.Abs(started.X-ended.X), Math.Abs(started.Y-ended.Y)) /2;
            int count = 0;
            for (double angle = 0; angle <= 2*Math.PI && count < no; angle += 2*Math.PI/no, count++)
            {  
                Console.WriteLine(count);
                temp.X = p.X + (int)(radius*Math.Cos(angle));
                temp.Y = p.Y + (int)(radius*Math.Sin(angle));
                ps[count] = temp;
                temp.X = 0;
                temp.Y = 0;
            }
            if (fill) graphics.FillPolygon(tools.brush, ps);
            graphics.DrawPolygon(tools.pen, ps);
        }

        public override void finishDraw()
        {
            path.AddPolygon(ps);
        }

        public void setFill(bool fill)
        {
            this.fill = fill; 
        }
        
        
    }
}