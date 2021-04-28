using System.Drawing;

namespace DrawApp
{
    class Rect : Shape
    {
        public Rect(Pen pen) : base(pen)
        {
        }

        public override void Draw(Graphics context)
        {
            if (EndPoint.X > StartPoint.X && EndPoint.Y > StartPoint.Y)
                context.DrawRectangle(this.Pen,
                    StartPoint.X, StartPoint.Y
                    , EndPoint.X - StartPoint.X, EndPoint.Y - StartPoint.Y
                 );
            else if(EndPoint.X < StartPoint.X && EndPoint.Y > StartPoint.Y)
            {
                context.DrawRectangle(this.Pen,
                   EndPoint.X, StartPoint.Y
                   , StartPoint.X - EndPoint.X, EndPoint.Y - StartPoint.Y
                   );
            }
            else if (EndPoint.X > StartPoint.X && EndPoint.Y < StartPoint.Y)
            {
                context.DrawRectangle(this.Pen,
                   StartPoint.X, EndPoint.Y
                   , EndPoint.X - StartPoint.X , StartPoint.Y - EndPoint.Y 
               
                 );
            }
            else if (EndPoint.X < StartPoint.X && EndPoint.Y < StartPoint.Y)
            {
                context.DrawRectangle(this.Pen,
                   EndPoint.X, EndPoint.Y
                   , StartPoint.X -EndPoint.X, StartPoint.Y - EndPoint.Y
                   );
            }
        }
    }
}
