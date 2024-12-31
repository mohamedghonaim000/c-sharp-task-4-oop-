using System;

namespace Last_session_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex() { real = 1, imag = 2 };
            Complex c2 = new Complex() { real = 2, imag = 3 };

            #region + -
            //Complex c3 =++ c1 ;
            //Complex c3 = c1++;

            //Console.WriteLine(c3);
            //Console.WriteLine(c1);

            #endregion

            #region < , > ,== ,!=
            //if (c2 == c2)
            //{
            //    Console.WriteLine("iam here");
            //}
            //else
            //{
            //    Console.WriteLine("noooooooooooooooooooo");
            //}; 
            #endregion

            #region Casting
            //c1 = c2 + 5;
            //Console.WriteLine(c1);

            //int y = (int)c2 + 1;
            //Console.WriteLine(y); 
            #endregion
        }
    }
}
