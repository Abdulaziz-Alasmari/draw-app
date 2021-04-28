using System;
using System.Drawing;

namespace DrawApp
{
    public abstract class Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen Pen { get; protected set; }
        public bool IsSelected { get; set; }

        public Shape(Pen pen)
        {
            SetPen(pen);
            IsSelected = false;
        }

        // draw func
        abstract public void Draw(Graphics context);

        public Shape SetPen(Pen pen)
        {
            if (pen == null) throw new ArgumentNullException();

            this.Pen = pen;

            return this;
        }
    }
}
