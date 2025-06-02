using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_W12A_Jevon_Valentino_160424066
{
    public class Coord2D
    {
        private int x;
        private int y;

        public Coord2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public string Display()
        {
            string output = "(" + this.X + "," + this.Y + ")";
            return output;
        }

        public double CalculateDistance(Coord2D obj)
        {
            double a = Math.Pow(obj.X - this.X, 2); // (x2-x1)^2
            double b = Math.Pow(obj.Y - this.Y, 2); // (y2-y1)^2           
            return Math.Pow(a+b,0.5);
        }
    }
}