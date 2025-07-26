namespace Assignment.Q4
{
    internal class FixedSizeList<T>
    {
        private readonly int capacity;
        private readonly List<T> internalList;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            this.capacity = capacity;
            this.internalList = new List<T>(capacity);
        }

        public void Add(T item)
        {
            if (internalList.Count >= capacity)
                throw new InvalidOperationException($"Cannot add more elements. FixedSizeList capacity of {capacity} has been reached.");

            internalList.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= internalList.Count)
                throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. Valid range: 0 to {internalList.Count - 1}");

            return internalList[index];
        }

        public int Count => internalList.Count;

        public int Capacity => capacity;
    }


}
