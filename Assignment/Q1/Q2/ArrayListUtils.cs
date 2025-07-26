using System.Collections;

namespace Assignment.Q1.Q2
{
    internal class ArrayListUtils
    {
        public static void ReverseArrayList(ArrayList list)
        {
            int left = 0;
            int right = list.Count - 1;
            while(left < right)
            {
                object? temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;

            }

        }
    }
}
