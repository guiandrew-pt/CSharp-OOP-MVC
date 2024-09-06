namespace InterfacesIComparable.Entities
{
	public class Employee : IComparable
	{
		public string Name { get; set; }
		public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] arr = csvEmployee.Split(',');
            Name = arr[0];
            Salary = double.Parse(arr[1]);
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee!");
            }

            Employee? other = obj as Employee;

            // return Name.CompareTo(other?.Name);
            return Salary.CompareTo(other?.Salary);
        }

        public override string ToString()
        {
            return $"{Name}, {Salary.ToString("F2")}";
        }
    }
}

