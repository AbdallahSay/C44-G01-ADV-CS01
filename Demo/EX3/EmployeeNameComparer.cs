using Demo.EX1;

namespace Demo.EX3
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x is null && y is null) return 0; // Both are null
            return string.Compare(x?.Name, y?.Name);
        }
    }
}
