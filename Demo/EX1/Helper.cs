using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.EX1
{
    internal static class Helper<T>
    {
        #region Swap - Non Generic 
        //public static void Swap (ref object x , ref  object y)
        //{
        //    object temp = x;
        //    x = y;
        //    y = temp;
        //}
        ////Swap 2 integers using ref parameters
        //public static void Swap(ref int x , ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        ////Swap 2 decimal
        //public static void Swap(ref decimal x , ref decimal y)
        //{
        //    decimal temp = x;
        //    x = y;
        //    y = temp;
        //}
        ////Swap 2 Point
        //public static void Swap(ref Point p1 ,  ref Point p2)
        //{
        //   Point temp = p1;
        //   p1.X = p2.X; p1.Y = p2.Y;
        //   p2.X = temp.X; p2.Y = temp.Y;



        //}
        #endregion
        #region Swap - Generic
        public static void Swap (ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion
    }
}
