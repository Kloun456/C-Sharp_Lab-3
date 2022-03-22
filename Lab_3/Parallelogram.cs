using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Parallelogram : Figure
    {
        public double Side { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return Side * Height; }
        public override Point GetCenter() { return new Point((Position.X + (int)Height) / 2, Position.Y + (int)Height / 2); }
        public override void Draw(Graphics gr)
        { 
            Point[] points = { new Point(Position.X, Position.Y), new Point(Position.X + (int)Side, Position.Y),
            new Point(Position.X + (int)Height, Position.Y + (int)Height), 
            new Point(Position.X + (int)Height - (int)Side, Position.Y + (int)Height)
            };
            gr.DrawPolygon(new Pen(Color.Green), points);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}

