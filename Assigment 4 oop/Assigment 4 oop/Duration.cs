using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assigment_4_oop
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }

        public int Seconds { get; set; }

        public Duration(int _hours , int _minutes, int _second) { 
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _second;
        }

        public Duration(int number )
        {
            Hours = number /3600;
            Minutes = (number-Hours*3600)/60;
            Seconds = (number- Hours * 3600 - Minutes*60)/60;
        }


        public static Duration   operator +(Duration a, Duration b)
        {
            int totalsecond = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) + (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
            return new Duration(totalsecond);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            int totalsecond; 
            if (a.Hours > b.Hours)
            {
                totalsecond = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds) - (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);
                return new Duration(totalsecond);

            }
            totalsecond = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds) - (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            return new Duration(totalsecond);

        }

        public static bool operator >(Duration a, Duration b)
        {
            int totalsecondofa = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int totalsecondofb = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);

            if (totalsecondofa > totalsecondofb)
            {
                return true;
            }
            return false;

        }

        public static bool operator <(Duration a, Duration b)
        {
            int totalsecondofa = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int totalsecondofb = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);

            if (totalsecondofa < totalsecondofb)
            {
                return true;
            }
            return false;

        }
        public static bool operator <=(Duration a, Duration b)
        {
            int totalsecondofa = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int totalsecondofb = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);

            if (totalsecondofa < totalsecondofb || totalsecondofa == totalsecondofb)
            {
                return true;
            }
            return false;

        }

        public static bool operator >=(Duration a, Duration b)
        {
            int totalsecondofa = (a.Hours * 3600 + a.Minutes * 60 + a.Seconds);
            int totalsecondofb = (b.Hours * 3600 + b.Minutes * 60 + b.Seconds);

            if (totalsecondofa > totalsecondofb || totalsecondofa == totalsecondofb)
            {
                return true;
            }
            return false;

        }
        public static Duration operator ++ (Duration a)
        {
            int totalsecond = a.Hours * 3600 + (a.Minutes+1 )* 60 + a.Seconds;
            return new Duration(totalsecond);
       
        }

        public static Duration operator --(Duration a)
        {
            int totalsecond = a.Hours * 3600 + (a.Minutes -1) * 60 + a.Seconds;
            return new Duration(totalsecond);

        }


        public static implicit operator Duration(int num)
        {
            return new Duration(num );
        }

        public static  implicit operator bool(Duration a)
        {
            if (a.Hours != 0 || a.Minutes != 0 || a.Seconds != 0)
            {
                return true ;
            }
            return false;   
        }

        public static explicit operator int (Duration a)
        {
            int totalsecond = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
            return totalsecond;
        }

        public static explicit operator DateTime(Duration a)
        {
           
            return new DateTime(1,1,1 , a.Hours, a.Minutes, a.Seconds); //////////////////////////
        }



        public override string ToString()
        {
            return $" hours : {Hours} minuts : {Minutes} second : {Seconds}";
        }
        public override bool Equals( object obj)
        {
            if (obj is Duration other ) { 
                other = (Duration) obj;
            
                return this.Hours == other.Hours && this.Minutes == other.Minutes && this.Seconds == other.Seconds;

            }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17; 
            hash = hash * 31 + Hours.GetHashCode();  
            hash = hash * 31 + Minutes.GetHashCode(); 
            hash = hash * 31 + Seconds.GetHashCode(); 
            return hash;
        }

    }
}
