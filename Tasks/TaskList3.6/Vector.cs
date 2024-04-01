using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList3._6
{
    public class Vector
    {


        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }


        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }


        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
        public override bool Equals(object obj)
        {
            var v = (Vector)obj;
            if (v == null)
            {
                return false;
            }
            else
            {
                return (v.X == this.X) && (v.Y == this.Y);
            }
        }
        
    }
}
