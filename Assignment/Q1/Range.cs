namespace Assignment.Q1
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Numerics;

    public class Range<T> where T : IComparable<T>  , INumber<T>
    {
        public T min;
        public T max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                Console.WriteLine("Minimum value cannot be greater than maximum value");

            this.min = min;
            this.max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }
        public T Length()
        {
            return max - min;
        }


    }
    
}
