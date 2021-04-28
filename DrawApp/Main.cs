using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Main : Form
    {
        List<Shape> shapes = new List<Shape>();

        ShapeType selectedShapeType = ShapeType.Line;
        Pen pen = new Pen(Brushes.Black, 5);

        /**
         * Tracking drawing line
         * 
         */
        Point startPoint;
        Point currentPoint;
        bool isMouseDown = false;
        GraphicsPath gPaths = new GraphicsPath();

        public Main()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (Shape shape in shapes) shape.Draw(e.Graphics);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsSelectingShape(e.Location))
            {
                ((Panel)sender).Invalidate();
                return;
            }

            startPoint = e.Location;
            currentPoint = e.Location;

            if (selectedShapeType == ShapeType.Line)
            {
                // todo: check if left button clicked
                shapes.Add(new Line(pen)
                {
                    StartPoint = startPoint,
                    EndPoint = currentPoint
                });
            }
            else if (selectedShapeType == ShapeType.Rect)
            {
                shapes.Add(new Rect(pen)
                {
                    StartPoint = startPoint,
                    EndPoint = currentPoint
                });
            }
            else if (selectedShapeType == ShapeType.Circle)
            {
                shapes.Add(new Circle(pen)
                {
                    StartPoint = startPoint,
                    EndPoint = currentPoint
                });
            }
            isMouseDown = true;

        }
        protected bool IsSelectingShape(Point mouseClickLocation)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                gPaths.Reset();
                gPaths.AddLine(shapes[i].StartPoint, shapes[i].EndPoint);
                if (gPaths.IsOutlineVisible(mouseClickLocation, pen))
                {
                    shapes[i].IsSelected = true;
                    shapes[i].SetPen(new Pen(Brushes.Red, pen.Width));
                    return true;
                }
            }

            return false;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.selectedShapeType = ShapeType.Circle;
        }

        private void penPropButton_Click(object sender, EventArgs e)
        {
            PenProps penProps = new PenProps();
            if (penProps.ShowDialog() == DialogResult.OK)
            {
                    pen = penProps.NewPen;
            };
            penProps.Dispose();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

            if (selectedShapeType == ShapeType.Line)
            {
                Line lastLine = shapes[shapes.Count - 1] as Line;
                isMouseDown = false;
            }
            isMouseDown = false;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                if (selectedShapeType == ShapeType.Line) shapes[shapes.Count - 1].EndPoint = e.Location;
                else if (selectedShapeType == ShapeType.Rect) shapes[shapes.Count - 1].EndPoint = e.Location;
                else if (selectedShapeType == ShapeType.Circle) shapes[shapes.Count - 1].EndPoint = e.Location;

                ((Panel)sender).Invalidate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Line;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Rect;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            this.panel1.Invalidate();
        }

    }
}
