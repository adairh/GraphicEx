using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicEx
{
    public class CombinationShape : Shape
    {
        private List<Shape> shapes;
        private Point init;
        public CombinationShape(Graphics graphics) : base(graphics)
        {
            shapes = new List<Shape>();
            init = started;
        }
        public override void generateBound()
        {
            started = GetTopLeftPoint();
            ended = GetBottomRightPoint();
            base.generateBound();
        }
        private Point GetTopLeftPoint()
        {
            int minX = int.MaxValue;
            int minY = int.MaxValue;
    
            foreach (Shape shape in shapes)
            {
                minX = Math.Min(minX, Math.Min(shape.started.X, shape.ended.X));
                minY = Math.Min(minY, Math.Min(shape.started.Y, shape.ended.Y));
            }
    
            return new Point(minX, minY);
        }

        private Point GetBottomRightPoint()
        {
            int maxX = int.MinValue;
            int maxY = int.MinValue;
    
            foreach (Shape shape in shapes)
            {
                maxX = Math.Max(maxX, Math.Max(shape.started.X, shape.ended.X));
                maxY = Math.Max(maxY, Math.Max(shape.started.Y, shape.ended.Y));
            }
    
            return new Point(maxX, maxY);
        }

        public void addShape(Shape shape)
        {
            shapes.Add(shape);
        }
        
        public override void Draw()
        {
            foreach (Shape s in shapes)
            {
                s.generateBound();
                s.Draw();
            }
        }

        public override void adjustSEXY(int sx, int sy, int ex, int ey)
        {
            foreach (Shape s in shapes)
            {
                s.adjustSEXY(sx, sy, ex, ey);
                
                //MessageBox.Show(s.started + " " + s.ended + " : " + ss.started + " " + ss.ended);
            }
            base.adjustSEXY(sx, sy, ex, ey);
            
        }

        public override void finishDraw()
        {
            
        }
    }
}