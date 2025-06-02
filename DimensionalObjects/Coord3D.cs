using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tugas_W12A_Jevon_Valentino_160424066
{
    public class Coord3D : Coord2D
    {
        private int z;

        public Coord3D(int x, int y, int z):base(x,y)
        {
            this.Z = z;
        }

        public int Z { get => z; set => z = value; }

        public string Display()
        {
            string output = "(" + base.X + "," + base.Y + "," + this.Z + ")";
            return output;
        }
        public double CalculateDistance(Coord3D obj)
        {
            double a = Math.Pow(obj.X - this.X, 2); // (x2-x1)^2
            double b = Math.Pow(obj.Y - this.Y, 2); // (y2-y1)^2   
            double c = Math.Pow(obj.Z - this.Z, 2); // (z2-z1)^2
            return Math.Pow(a + b + c, 0.5);
        }
    }
}