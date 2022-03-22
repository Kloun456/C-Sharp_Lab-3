using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Rhombus : Figure
    {
        public double A_diagonal { set; get; }
        public double B_diagonal { set; get; }
        public override double GetArea() { return (A_diagonal * B_diagonal) / 2; }
        public override Point GetCenter() { return new Point((int)(Position.X), (int)(Position.Y + B_diagonal / 2)); }
        public override void Draw(Graphics gr)
        {
            Point[] points = { new Point(Position.X, Position.Y), 
            new Point(Position.X + (int)A_diagonal / 2, Position.Y + (int)B_diagonal / 2),
            new Point(Position.X, Position.Y + (int)B_diagonal),
            new Point(Position.X - (int)A_diagonal / 2, Position.Y + (int)B_diagonal / 2)};
            gr.DrawPolygon(new Pen(Color.Green), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
