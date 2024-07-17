using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int _x)
        {
            X = Y = Z = _x;
        }
        public Point3D(int _x, int _y):this(_x)
        {
            Y = _y;   
        }
        public Point3D(int _x, int _y, int _z):this(_x, _y)
        {
            Z = _z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static explicit operator string(Point3D p)
        {
            return $"Point is ({p.X}, {p.Y}, {p.Z})";
        }

      
    }
}
