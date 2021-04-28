using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawApp
{

    public abstract class Shape
    {
        // todo: refactoring: Create structre for Shape Points and Their selectors
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen Pen { get; protected set; }
        public bool IsSelected { get; set; }
        public List<Rectangle> Selectors { get; set; }

        public Shape(Pen pen)
        {
            SetPen(pen);
            IsSelected = false;
            Selectors = new List<Rectangle>();
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
