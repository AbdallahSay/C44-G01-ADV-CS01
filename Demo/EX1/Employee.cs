namespace Demo.EX1
{
    internal class Employee
    {
        #region Prop
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public string Name { get; set; } 
        #endregion
        #region Ctor
        public Employee(int id, decimal salary, string name)
        {
            Id = id;
            Salary = salary;
            Name = name;
        } 
        #endregion

        #region Override ToString
        override public string ToString()
        {
            return $"Id: {Id}, Salary: {Salary}, Name: {Name}";
        }
        //public override bool Equals(object? obj)
        //{
        //    Employee? employee = (Employee?)obj;
        //    if (employee is not null)
        //    {
        //        return Id == employee.Id &&
        //               Salary == employee.Salary &&
        //               Name == employee.Name;
        //    }
        //    return false;
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id, Salary, Name);
        //}
        //public override bool Equals(object? obj)
        //{
        //    if (obj is Employee employee)
        //    {
        //        return Id == employee.Id &&
        //               Salary == employee.Salary &&
        //               Name == employee.Name;
        //    }
        //    return false;
        //}
        #endregion
        #region Operator Overloading
        public static bool operator ==(Employee left , Employee right)
        {
            //return left.Id == right.Id &&
            //       left.Salary == right.Salary &&
            //       left.Name == right.Name;
            return left.Equals(right);
        }
        public static bool operator !=(Employee left , Employee right)
        {
            //return left.Id != right.Id &&
            //       left.Salary != right.Salary &&
            //       left.Name != right.Name;
            return !(left.Equals(right));
        }

       

        #endregion


    }
}
