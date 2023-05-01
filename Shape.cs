using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicEx
{
    public abstract class Shape
    {

        public static int ii = 0;
        public int id = 0;
        public RectangleF bounds;
        public Tools tools;
        public Point started, ended;
        protected Graphics graphics;
        protected GraphicsPath path;
        public Shape parentShape;
        public Shape(Graphics graphics)
        {
            id = ii;
            ii++;
            tools = new Tools();
            path = new GraphicsPath();
            this.graphics = graphics;
            bounds = new RectangleF();
            parentShape = null;
        }
        
        public abstract void Draw();

        public void Drawing(Panel p)
        {
            generateBound();
            p.Refresh();
            Draw();
        }

        public virtual void generateBound()
        {
            bounds.X = started.X < ended.X ? started.X : ended.X;
            bounds.Y = started.Y < ended.Y ? started.Y : ended.Y;
            bounds.Width = Math.Abs(ended.X - started.X);
            bounds.Height = Math.Abs(ended.Y - started.Y);
        }
        
        public double getDistance()
        {
            return (Math.Sqrt((started.X - ended.X) * (started.X - ended.X) +
                       (started.Y - ended.Y) * (started.Y - ended.Y)));
        }
        public virtual void adjustSEXY(int SX, int SY, int EX, int EY)
        {
            started.X += SX;
            started.Y += SY;
            ended.X += EX;
            ended.Y += EY;
        }

        private int tSX, tSY, tEX, tEY, coX, coY;
        public virtual void scale(int delta)
        {
            Shape alter = this;
            // Get the number of scrolling steps.
            int scrollDelta = delta;
            //
            // MessageBox.Show((alter.ended.X - alter.started.X) / alter.getDistance() * 5 + " " +
            //                 (alter.ended.Y - alter.started.Y) / alter.getDistance() * 5);
            coX = (int)((double)(alter.ended.X - alter.started.X) / alter.getDistance() * 10);
            coY = (int)((double)(alter.ended.Y - alter.started.Y) / alter.getDistance() * 10);
            
            if (scrollDelta > 0)
            {
                tSX = alter.started.X - coX;
                tSY = alter.started.Y - coY;
                    
                tEX = alter.ended.X + coX;
                tEY = alter.ended.Y + coY;
            }
            else
            {
                tSX = alter.started.X + coX;
                tSY = alter.started.Y + coY;
                    
                tEX = alter.ended.X - coX;
                tEY = alter.ended.Y - coY;
            }
            
            if (/*tSX <= 0 
                || tSY <= 0
                || tEX >= plMain.Bounds.Width
                || tEY >= plMain.Bounds.Height
                ||*/ tSX >= tEX 
                     || tSY >= tEY)
            {
                //return;
            }

            alter.started.X = tSX;
            alter.started.Y = tSY;

            alter.ended.X = tEX;
            alter.ended.Y = tEY;
            alter.Draw();
            //MessageBox.Show(alter.GetType().ToString());
        }
        
        public abstract void finishDraw();

        public GraphicsPath getPath()
        {
            return path;
        }

        public int getID()
        {
            return id;
        }

        /*public static void updateShape(int i, Shape s)
        {
            foreach (Shape sh in Program.shapes.Values)
            {
                if (sh.id == i)
                {
                    Program.shapes.Remove(sh);
                    Program.shapes.Add(s);
                    break;
                }
            }
        }*/
    }
}