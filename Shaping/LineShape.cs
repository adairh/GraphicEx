using System.Drawing;

namespace GraphicEx
{
    public class LineShape : Shape
    {
        public LineShape(Graphics graphics) : base(graphics)
        { 
        }
        public override void Draw()
        {
            graphics.DrawLine(tools.pen, started, ended);
            
        }

        public override void finishDraw()
        {
            path.AddLine(started, ended);
        }
    }
}