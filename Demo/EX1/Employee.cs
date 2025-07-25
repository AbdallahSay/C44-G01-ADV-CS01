namespace Demo.EX1
{
    internal struct Employee
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
