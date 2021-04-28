using System.Drawing;

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
        }
    }
}
