using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_session_oop
{
    internal class Complex
    {
        public int real {  get; set; }
        public int imag { get; set; }

        #region overloading binary operator (+ , -)
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                real = (left?.real?? 0) + (right?.real??0),
                imag = (left?.imag??0) + (right?.imag??0)
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                real = left.real - right.real,
                imag = left.imag - right.imag,
            };
        }
        #endregion

        #region overloading unary operator
        public static Complex operator ++(Complex c)
        {

            return new Complex()
            {
                real = c.real + 1,
                imag = c.imag + 1
            };
        }
        public static Complex operator --(Complex c)
        {

            return new Complex()
            {
                real = c.real - 1,
                imag = c.imag - 1
            };
        }
        #endregion

        #region overloading (< ,> , == , != )
        public static bool operator >(Complex left, Complex right)
        {
            return left.real > right.real;
        }
        public static bool operator <(Complex left, Complex right)
        {
            return left.real > right.real;
        }

        public static bool operator == (Complex left, Complex right)
        {
            return left.real == right.real;
        }

        public static bool operator !=(Complex left, Complex right)
        {
            return left.real == right.real;
        }
        #endregion

        #region casting overloading
        public static implicit operator Complex(int num)
        {
            return new Complex() { imag = num, real = num };
        }
        public static explicit operator int(Complex c)
        {
            return c.real;
        } 
        #endregion




        public override string ToString()
        {
            return $"real : {real} imag : {imag}";
        }
    }
}
