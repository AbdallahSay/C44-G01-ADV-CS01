namespace Assignment.Q3
{
    internal class EvenNumber
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    evenNumbers.Add(num);
            }

            return evenNumbers;
        }

    }
}
