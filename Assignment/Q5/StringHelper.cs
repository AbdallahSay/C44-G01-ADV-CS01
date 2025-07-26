namespace Assignment.Q5
{
    internal class StringHelper
    {
        public static int FirstUniqueCharIndex(string input)
        {
            Dictionary<char, int> frequency = new();
            Dictionary<char, int> firstIndex = new();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                {
                    frequency[c] = 1;
                    firstIndex[c] = i;
                }
            }

            foreach (var kvp in frequency)
            {
                if (kvp.Value == 1)
                    return firstIndex[kvp.Key];
            }

            return -1; // No unique character
        }
    }
}
