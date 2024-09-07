namespace AddEmployeeList
{
	public class Employee
	{
        // Properties:
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        // Constructor:
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        // Methods:
        public void IncreaseSalary(double pecentage)
        {
            Salary += Salary * pecentage / 100.0; 
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", $"
                + Salary.ToString("F2");
        }
    }
}

