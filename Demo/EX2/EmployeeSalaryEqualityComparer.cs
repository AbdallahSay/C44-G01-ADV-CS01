using Demo.EX1;
using System.Diagnostics.CodeAnalysis;
namespace Demo.EX2
{
    internal class EmployeeSalaryEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Salary == y?.Salary;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
           return HashCode.Combine(obj.Salary);
        }
    }
}
