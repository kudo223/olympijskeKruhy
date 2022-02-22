using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Kunc
{
    public class Kruhy
    {
        public Color Kruh1 { get; set; }
        public Color Kruh2 { get; set; }
        public Color Kruh3 { get; set; }
        public Color Kruh4 { get; set; }
        public Color Kruh5 { get; set; }
        public int Velikost = 5;
        public int X = 5;
        public int Y = 5;
        public Point Lokace;
        public Kruhy()
        {
            Kruh1 = Color.Chocolate;
            Kruh2 = Color.Tomato;
            Kruh3 = Color.Salmon;
            Kruh4 = Color.Thistle;
            Kruh5 = Color.Peru;
            Velikost = 10;
            X = 5;
            Y = 5;
        }
        public Kruhy(Color kruh1, Color kruh2, Color kruh3, Color kruh4, Color kruh5, int velikost, int x, int y)
            {
            Kruh1 = kruh1;
            Kruh2 = kruh2;
            Kruh3 = kruh3;
            Kruh4 = kruh4;
            Kruh5 = kruh5;
            Velikost = velikost;
            X = x;
            Y = y;
        }
        public void Draw(Graphics graphics)
        {
            Pen pen1 = new Pen(Kruh1);
            Pen pen2 = new Pen(Kruh2);
            Pen pen3 = new Pen(Kruh3);
            Pen pen4 = new Pen(Kruh4);
            Pen pen5 = new Pen(Kruh5);
            pen1.Width = 2;
            pen2.Width = 2;
            pen3.Width = 2;
            pen4.Width = 2;
            pen5.Width = 2;
            graphics.DrawEllipse(pen1, Lokace.X, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen2, Lokace.X + Velikost/2+Velikost/2+Velikost/4-Velikost/8, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen3, Lokace.X + Velikost+Velikost/2+Velikost-Velikost/4, Lokace.Y, Velikost, Velikost);
            graphics.DrawEllipse(pen4, Lokace.X + Velikost / 4 + Velikost /4+Velikost/12, Lokace.Y+Velikost/2+Velikost/4, Velikost, Velikost);
            graphics.DrawEllipse(pen5, Lokace.X + Velikost / 2 + Velikost/2+Velikost/4-Velikost/8+Velikost/2+Velikost/12, Lokace.Y + Velikost / 2+Velikost/4,Velikost, Velikost);
        }
    }
}
