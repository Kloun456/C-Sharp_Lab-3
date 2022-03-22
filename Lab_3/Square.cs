﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    class Square : Figure
    {
        public double Side { set; get; }
        public override double GetArea() { return Side * Side; }
        public override Point GetCenter() { return new Point((int)(Position.X + Side / 2), (int)(Position.Y + Side / 2)); }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Side, (int)Side);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
