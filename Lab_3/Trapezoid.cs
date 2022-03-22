using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Trapezoid : Figure
    {
        public double A_side { set; get; }
        public double B_side { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return (A_side + B_side) / 2 * Height; }
        public override Point GetCenter() { return new Point((int)(Position.X + A_side / 2), (int)(Position.Y + Height / 2)); }
        public override void Draw(Graphics gr)
        {
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X + (int)A_side, Position.Y),
            new Point(Position.X + (int)(Height + B_side - A_side), Position.Y + (int)Height),
            new Point(Position.X + (int)Height - (int)A_side, Position.Y + (int)Height)
            };
            gr.DrawPolygon(new Pen(Color.Black), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
