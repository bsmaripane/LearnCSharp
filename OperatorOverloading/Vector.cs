using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Vector
    {
        public int X {  get; set; }
        public int Y {  get; set; }
        public Vector(int x, int y)
        {
            X = x; Y = y;
        }
        public void Display() => Console.WriteLine($"Vector: ({X}, {Y})");

        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X+v2.X,v1.Y+v2.Y);
        public Vector Add(Vector other) => new Vector(this.X+other.X,this.Y+other.Y);
    }
}
