namespace Demo.EX1
{
    internal static class Helper<T> where T : IEquatable<T>
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
        public static void Swap<T> (ref T x , ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        #endregion
        #region Linear Search - Non Generic
        //public static int LinearSearch(ref int[] arr ,  int target)
        //{
        //    if(arr is not null && arr.Length > 0)
        //        for(int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == target)
        //                return i;
        //        }
        //    return -1;
        //}





        #endregion
        #region Linear Search - Generic
        public static int LinearSearch(T[] points, T target)
        {
            if (points is not null && points.Length > 0 && target is not null)
                for (int i = 0; i < points.Length; i++)
                {
                    if (target.Equals(points[i])) // User defined Struct can not use == operator
                        return i;
                }
            return -1;
        }
        public static int LinearSearch(T[] points  , T target , IEqualityComparer<T> comparer)
        {
            if(points is not null && points.Length > 0 && target is not null)
                for(int i = 0; i < points.Length; i++)
                {
                    if (target.Equals(points[i])) // User defined Struct can not use == operator
                        return i;
                }
            return -1;
        }
        #endregion
    }
}
