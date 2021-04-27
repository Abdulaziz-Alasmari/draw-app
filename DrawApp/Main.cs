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

namespace DrawApp
{
    public partial class Main : Form
    {
        List<Shape> shapes = new List<Shape>();

        ShapeType selectedShapeType = ShapeType.Line;
        Pen pen = new Pen(Brushes.Black, 10);

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
            foreach (Shape shape in shapes)
            {
                if (shape.IsSelected == false) shape.SetPen(pen);
                shape.Draw(e.Graphics);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(UnselectIfNeeded(e.Location))
            {
                ((Panel)sender).Invalidate();
            }

            int selectedShapeIndex = IsSelectingShape(e.Location);

            if (selectedShapeIndex != -1)
            {
                MarkAsSelected(selectedShapeIndex);
                ((Panel)sender).Invalidate();
                return;
            }
            

            if (selectedShapeType == ShapeType.Line)
            {
                // todo: check if left button clicked
                startPoint = e.Location;
                currentPoint = e.Location;
                shapes.Add(new Line(pen)
                {
                    StartPoint = startPoint,
                    EndPoint = currentPoint
                });
                isMouseDown = true;
            }
        }

        public bool UnselectIfNeeded(Point mouseClickLocation)
        {
            int indexOfSelectedShape = IsSelectingShape(mouseClickLocation);

            for (int i = 0; i < shapes.Count; i++)
            {
                if(shapes[i].IsSelected)
                {
                    shapes[i].IsSelected = (i == indexOfSelectedShape);
                    return true;
                }
            }

            return false;
        }

        protected int IsSelectingShape(Point mouseClickLocation)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                gPaths.Reset();
                gPaths.AddLine(shapes[i].StartPoint, shapes[i].EndPoint);
                if(gPaths.IsOutlineVisible(mouseClickLocation, pen))
                {
                    //shapes[i].IsSelected = true;
                    //shapes[i].SetPen(new Pen(Brushes.Red, pen.Width));
                    //return true;
                    return i;
                }
            }

            return -1;
        }

        protected void MarkAsSelected(int shapeIndex)
        {
            shapes[shapeIndex].IsSelected = true;
            shapes[shapeIndex].SetPen(new Pen(Brushes.Red, pen.Width));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.selectedShapeType = ShapeType.Circle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //.. code
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            if (selectedShapeType == ShapeType.Line)
            {
                Line lastLine = shapes[shapes.Count - 1] as Line;
                isMouseDown = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (selectedShapeType == ShapeType.Line)
            {
                if (isMouseDown)
                {
                    shapes[shapes.Count - 1].EndPoint = e.Location;
                    ((Panel)sender).Invalidate();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Line;
        }

    }
}
