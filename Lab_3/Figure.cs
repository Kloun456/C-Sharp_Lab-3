using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Test_form
{
    abstract class Figure
    {
        public string Name { set; get; }
        public Color Color { set; get; }
        public Point Position { set; get; }
        public abstract double GetArea();
        public abstract Point GetCenter();
        public abstract void Draw(Graphics gr);
    }
}