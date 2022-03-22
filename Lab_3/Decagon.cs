using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;

namespace Test_form
{
    class Decagon : Figure
    {
        public double Side { set; get; }
        public int Peaks { set; get; }
        public override double GetArea() { return 5 / 2 * Side * Math.Sqrt(5 + 2 * Math.Sqrt(5)); }
        public override Point GetCenter() { return new Point((int)(Position.X + Side / 2), (int)(Position.Y + (Side / 2) * (1 / Math.Tan(36 * Math.PI / 180)))); }
        public override void Draw(Graphics gr)
        {
            var angle = Math.PI * 2 / Peaks;
            var radius = (Side / 2) / Math.Sin((180 / Peaks) * Math.PI / 180);
            var points = Enumerable.Range(0, Peaks).Select(i => PointF.Add(GetCenter(),
                new SizeF((float)Math.Sin(i * angle) * (float)radius, (float)Math.Cos(i * angle) * (float)radius)));
            gr.DrawPolygon(Pens.Black, points.ToArray());
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
