using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_4_oop
{
    internal class Point3D : IComparable<Point3D> , ICloneable ,IComparer<Point3D>
    {
        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point3D() { }
        public Point3D(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public Point3D(int _x, int _y , int _z):this( _x,  _y)
        {
            z = _z;
        }

        public static bool operator == (Point3D a, Point3D b)
        {
            return a.x == b.x;
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            return a.x != b.x;
        }


        public override string ToString()
        {
            return $" x = {x} and y = {y} and z = {z}";
        }

        public int CompareTo(Point3D other)
        {
            return x.CompareTo(other.x) ; // how to arrange based on two values ?? 
        }

        public object Clone()
        {
            return new Point3D(x, y, z);
        }

        public int Compare(Point3D x, Point3D y)
        {
            throw new NotImplementedException();
        }

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //} shallow copy 
    }
}
