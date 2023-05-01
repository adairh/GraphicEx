using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEx
{
    public partial class Form1 : Form
    {
        Graphics gp;
        private mode m = mode.None;
        private Point tempPoint;
        bool isntStart=true;//a flag

        private Shape currentShape;
        
        
        private Shape movingShape;
        private Point clickedMovePoint;

        private List<Shape> movingShapes;

        private bool tempGroupWorking;
        
        public Form1()
        {
            InitializeComponent();
            
            movingShapes = new List<Shape>();
            gp = this.plMain.CreateGraphics();
            tempPoint = new Point();
            tempGroupWorking = false;
        }
        private void btnDuongThang_Click(object sender, EventArgs e)
        {
            //this.bLine = true;
            m = mode.Line;
            currentShape = new LineShape(gp);
        }
        private void btnRect_Click(object sender, EventArgs e)
        {
            m = mode.Rect;
            currentShape = new RectShape(gp);
        }
        
        
        private void btnFilledRect_Click(object sender, EventArgs e)
        {
            m = mode.FilledRect;
            currentShape = new RectShape(gp, true);
        }
        
        
        private void btnEclipse_Click(object sender, EventArgs e)
        {
            m = mode.Eclipse;
            currentShape = new ElipseShape(gp);
        }
        
        
        private void btnFilledEclipse_Click(object sender, EventArgs e)
        {
            m = mode.FilledEclipse;
            currentShape = new ElipseShape(gp, true);
        }
        
        private void btnArc_Click(object sender, EventArgs e)
        {
            m = mode.Arc;
            currentShape = new ArcShape(gp);
            currentShape.tools.data.Add(arcAngleBar.Value);
        }
        
        private void btnPolygon_Click(object sender, EventArgs e)
        {
            m = mode.Polygon;
            currentShape = new PolygonShape(gp);
            currentShape.tools.data.Add((int)polygonNum.Value);
        }
        private void btnFilledPolygon_Click(object sender, EventArgs e)
        {
            m = mode.FilledPolygon;
            currentShape = new PolygonShape(gp, true);
            currentShape.tools.data.Add((int)polygonNum.Value);
        }
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == null) {
                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
                    movingShapes.Add(getShapeAt(e.Location));
                    groupBTN.Enabled = true;
                }
                else
                {
                    movingShapes.Clear();
                    groupBTN.Enabled = false;
                    movingShape = getShapeAt(e.Location);
                    if (movingShape != null)
                    {
                        //MessageBox.Show(movingShape.id + "");
                        while (movingShape.parentShape != null)
                        {
                            //MessageBox.Show(movingShape.id + "");
                            movingShape = movingShape.parentShape;
                        }
                        //MessageBox.Show(movingShape.id + "");
                        clickedMovePoint = e.Location;
                    }
                }
                return;
            }
            if (isntStart)//first click
            {
                label2.Text = ("constructor fired");
                this.tempPoint.X = e.X;
                this.tempPoint.Y = e.Y;
                this.isntStart = false;
                currentShape.tools.pen = new Pen(penColor.Color, trackBar1.Value);
                DashStyle sd;
                DashStyle.TryParse(comboBox.SelectedItem.ToString(), true, out sd);
                currentShape.tools.pen.DashStyle = sd;
                currentShape.tools.brush = new SolidBrush(brushColor.Color);
                currentShape.started = tempPoint;
            }
        }


        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isntStart) //first click
            {
                /*Point p1 = new Point();
                Point p2 = new Point();
                p1 = this.beginPoint;
                p2.X = e.X;
                p2.Y = e.Y;
                //Draw a line
                currentShape.ended = p2;*/
                //currentShape.Draw();
                
                this.isntStart = true;
                this.m = mode.None;
                if (!Program.shapes.ContainsKey(currentShape.id))
                    Program.shapes.Add(currentShape.id, currentShape);
                //currentShape.finishDraw();
                currentShape = null;
            }
            else
            {
                clickedMovePoint = new Point();
                movingShape = null;
            }
        }

        private void drawSelZone(Shape s)
        {
            Point p1, p2;
            p1 = s.started;
            p2 = s.ended;
            Pen p = new Pen(Color.Black);
            p.DashStyle = DashStyle.Dot;
            gp.DrawRectangle(p, p1.X, p1.Y, (p2.X-p1.X), (p2.Y-p1.Y));
        }
        
        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            String sss = "";
            foreach (Shape s in Program.shapes.Values)
            {
                sss += (s.id.ToString());
            }

            label3.Text = sss;
            if (this.isntStart == false)
            {
                tempPoint.X = e.X;
                tempPoint.Y = e.Y;
                currentShape.ended = tempPoint;
                currentShape.Drawing(plMain);
                foreach (Shape s in Program.shapes.Values)
                {
                    s.Draw();
                }
            }
            else
            {
                if (movingShape != null)
                {
                    //if (movingShape is CombinationShape) return;
                    label1.Text = (e.X - clickedMovePoint.X) + " " +
                                  (e.Y - clickedMovePoint.Y) + " " +
                                  (e.X - clickedMovePoint.X) + " " +
                                  (e.Y - clickedMovePoint.Y);
                    movingShape.adjustSEXY(
                        e.X - clickedMovePoint.X, 
                        e.Y - clickedMovePoint.Y, 
                        e.X - clickedMovePoint.X,
                        e.Y - clickedMovePoint.Y);
                    clickedMovePoint = e.Location;
                    movingShape.Drawing(plMain);
                    foreach (Shape s in Program.shapes.Values)
                    {
                        s.Draw();
                    }
                    drawSelZone(movingShape);
                }
            }
        }

        
        private void plMain_MouseWheel(object sender, MouseEventArgs e)
        {
            Shape alter = getShapeAt(e.Location);
            alter.scale(e.Delta);
            foreach (Shape s in Program.shapes.Values)
            {
                s.Draw();
            }
        }

        enum mode
        {
            Line, Rect, FilledRect, Eclipse, FilledEclipse, Arc, Polygon, FilledPolygon, Combination, None
        }

        private void btnBrushColor(object sender, EventArgs e)
        {
            brushColor.ShowDialog();
            brushColorButton.BackColor = brushColor.Color;
        }
        
        private void btnPenColor(object sender, EventArgs e)
        {
            penColor.ShowDialog();
            penColorButton.BackColor = penColor.Color;
        }

        private Shape getShapeAt(Point p)
        {
            foreach (Shape shape in Program.shapes.Values)
            {
                if (shape.bounds.Contains(p))
                {
                    return shape;
                }
            }

            return null;
        }


        private void groupBTN_Click(object sender, EventArgs e)
        {
            if (movingShapes.Count > 0)
            {
                currentShape = new CombinationShape(gp);
                foreach (Shape sh in movingShapes)
                {
                    sh.parentShape = currentShape;
                    ((CombinationShape)currentShape).addShape(sh);
                    Program.shapes.Remove(sh.id);
                }

                
                groupBTN.Enabled = false;
                currentShape.generateBound();
                Program.shapes.Add(currentShape.id, currentShape);
                movingShapes.Clear();
                //already able to group shape but still cant move
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "M";
        }
    }
}