using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Circle : Figure
    {
        public double Radius { set; get; }
        public override double GetArea() { return Math.PI * Math.Pow(Radius, 2); }
        public override Point GetCenter() { return new Point((int)(Position.X + Radius), (int)(Position.Y + Radius)); }
        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, 2 *(int)Radius, 2 * (int)Radius);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
