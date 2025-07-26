namespace Demo.EX1
{
    internal class Employee: IEquatable<Employee> , IComparable<Employee> , IComparer<Employee>
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
        //    return obj is Employee employee &&
        //           Id == employee.Id &&
        //           Salary == employee.Salary &&
        //           Name == employee.Name;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id, Salary, Name);
        //}


        //public override bool Equals(object? obj)
        //{
        //    #region Explicit Casting 

        //    //    Employee? employee = (Employee?)obj;
        //    //    if (employee is not null)
        //    //    {
        //    //        return Id == employee.Id &&
        //    //               Salary == employee.Salary &&
        //    //               Name == employee.Name;
        //    //    }
        //    //    return false; 
        //    #endregion
        //    #region Is Operator
        //    //if(obj is null) return false;
        //    //else if (obj is Employee employee)
        //    //{
        //    //    return Id == employee.Id &&
        //    //           Salary == employee.Salary &&
        //    //           Name == employee.Name;
        //    //}
        //    //return false;
        //    #endregion
        //    #region As Operator
        //    Employee? employee = obj as Employee;
        //    if(employee is null ) return false;
        //    return Id == employee.Id &&
        //           Salary == employee.Salary &&
        //           Name == employee.Name;

        //    #endregion
        //Prop Pattern Matching
        //if (obj is Employee { Id : int id , Name : string name , Salary : decimal salary})
        //    return this.Id == id &&
        //           this.Salary == salary &&
        //           this.Name == name;
        //}
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Salary, Name);
        }
        public override bool Equals(object? obj)
        {
            if (obj is Employee employee)
            {
                return Id == employee.Id &&
                       Salary == employee.Salary &&
                       Name == employee.Name;
            }
            return false;
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

        #region IEquatable
        public bool Equals(Employee? other)
        {
            return other is not null &&
                    Id == other.Id &&
                    Salary == other.Salary &&
                    Name == other.Name;
        }

        public int CompareTo(Employee? other) // Return int

        {
            if(other is null) return 1; // this is greater than null
            return this.Salary.CompareTo(other.Salary);

        }

       

        public int Compare(Employee? x, Employee? y)
        {
            if (x is null && y is null) return 0; // both are null
            return string.Compare(x?.Name, y.Name);// Compare by Name

        }
        #endregion


    }
}
