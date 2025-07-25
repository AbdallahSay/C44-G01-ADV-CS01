using Demo.EX1;
using System.Diagnostics.CodeAnalysis;

namespace Demo.EX2
{
    internal class EmployeeNameEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
           if (x is null && y is null) return false;
            return x?.Name == y?.Name ;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
}
