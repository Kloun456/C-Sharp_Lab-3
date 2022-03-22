using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Test_form
{
    static class Program
    {
        public static Figure[] figures = {
            new Rhombus() { Name = "Ромб", Color = Color.Black, A_diagonal = 40, B_diagonal = 50, Position = new Point(200, 3) },
            new Parallelogram() { Name = "Параллелограмм", Color = Color.Red, Side = 50, Height = 30, Position = new Point(45, 90)},
            new Pentagon() {Name = "Пятиугольник", Color = Color.Green, Side = 50, Peaks = 5, Position = new Point(45, 2) },
            new Treangle() {Name = "Треугольник", Color = Color.Blue, Side = 40, Height = 30, Position = new Point(200, 90) },
            new Trapezoid() {Name = "Трапеция", Color = Color.Black, A_side = 40, B_side= 60, Height = 30, Position = new Point(45, 170)},
            new Decagon() {Name = "Десятиугольник", Color = Color.Green, Side = 25, Peaks = 10, Position = new Point(250, 190)},
            new Circle() {Name = "Круг", Color = Color.Black, Radius = 40, Position = new Point(45, 230)}
        };
        [STAThread]
        static void Main()
        {
            Form form = new Form1();
            form.Paint += Form_paint;
            Application.Run(form);
        }

        public static void Form_paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
                f.Draw(e.Graphics);
        }
    }
}
