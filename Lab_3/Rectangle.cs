using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Rectangle : Figure
    {
        public double Width { set; get; }
        public double Height { set; get; }
        public override double GetArea() { return Width * Height; }
        public override Point GetCenter() { return new Point((int)(Position.X + Width / 2), (int)(Position.X + Height / 2)); }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Width, (int)Height);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}