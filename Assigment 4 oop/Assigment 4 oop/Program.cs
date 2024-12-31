using System;

namespace Assigment_4_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region overloade ==
            //Point3D p1 = new Point3D(2, 5);
            //Point3D p2 = new Point3D(2, 5);

            //if (p1 == p2)
            //{
            //    Console.WriteLine("we are equal");
            //}
            #endregion

            #region second part in point 3D
            //Point3D[] point1 = new Point3D[2];

            //for (int i = 0; i < point1.Length; i++)
            //{
            //    Console.WriteLine($"enter the x axies point {i+1} ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"enter the y axies point {i+1} ");

            //    int y = Convert.ToInt32(Console.ReadLine());
            //    point1 [i] = new Point3D(x, y);

            //}

            //for (int i = 0; i < point1.Length; i++) {
            //    Console.WriteLine(point1[i]);
            //} 
            #endregion
            #region sort 
            //Point3D[] point1 = new Point3D[4]
            //{
            //    new Point3D(8,4,6),
            //    new Point3D(9,4,6),
            //    new Point3D(12,4,6),
            //    new Point3D(13,4,6),
            //};

            //Array.Sort(point1);

            //for (int i = 0; i < point1.Length; i++)
            //{
            //    Console.WriteLine(point1[i]);
            //} 
            #endregion

            #region Deep copy using Iclonable 
            //Point3D c3 = new Point3D(8, 4, 4);

            //Point3D c4 = new Point3D();

            //c4 = (Point3D)c3.Clone();

            //c4.x = 18;

            //Console.WriteLine(c4);
            //Console.WriteLine(c3);

            #endregion
            /////////////////////////////////////////// second problem /////////////////////

            //int x = 90;
            //int y = 30;
            //Console.WriteLine (Math.subtarct(x, y));
            //Console.WriteLine(Math.Add(x, y));
            //Console.WriteLine(Math.multiply(x, y));
            //Console.WriteLine(Math.divide(x, y));

            /////////////////////////////////////////// third problem //////////////////
            ///
            //Duration d1 = new Duration(7800);

            //Console.WriteLine(d1);

            Duration d2 = new Duration(2, 30, 60);
            Duration d3 = new Duration(3, 20, 50);
            Duration d5 =new Duration(3600);
            Duration d6 = new Duration(8000);


            //Duration D4 = d2 + d1;
            //d5 = d5 + 3600;
            //d5 = 3600 + d2;

            //Console.WriteLine(d5);

            //int y = (int)d6;
            //Console.WriteLine(y);
            //Console.WriteLine( ++ d3);
            //Console.WriteLine(--d2);

            //if (d2 > d3)
            //{
            //    Console.WriteLine("iam here");
            //}
            //else if (d2 < d5) {
            //    Console.WriteLine("iam not here ");
            //} else {
            //    Console.WriteLine("we are equal");
            //}

            //DateTime obj = (DateTime)d2;
            //Console.WriteLine(obj); return exciption 

            //if (d2)
            //{
            //    Console.WriteLine("hi");
            //}
















        }
    }
}
