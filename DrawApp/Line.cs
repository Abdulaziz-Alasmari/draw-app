using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    public class Line : Shape
    {
        public Line(Pen pen) : base(pen)
        {
        }

        public override void Draw(Graphics context)
        {
            context.DrawLine(this.Pen,
                StartPoint.X, StartPoint.Y
                , EndPoint.X, EndPoint.Y
                );

            Selectors.Clear();

            if (IsSelected)
                DrawSelectors(context);

            //else if(Selectors.Count > 0) Selectors.Clear();
        }

        protected void DrawSelectors(Graphics context)
        {
            Selectors.Add(new Rectangle(StartPoint, new Size(5, 5)));
            Selectors.Add(new Rectangle(EndPoint, new Size(5, 5)));

            context.DrawRectangles(new Pen(Brushes.Green, 5), Selectors.ToArray());
        }
    }
}
