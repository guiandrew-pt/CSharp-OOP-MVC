namespace ChangeEmployeeData
{
	public class Employee
	{
		// Properties:
		public string Name { get; set; }
		public double Salary { get; set; }
		public double Tax { get; set; }

		// Constructor:
		public Employee(string name, double salary, double tax)
		{
			Name = name;
			Salary = salary;
			Tax = tax;
		}

		// Method:
		public double NetSalary()
		{
			return Salary - Tax;
		}

		public void IncreaseSalary(double percentage)
		{
			Salary += Salary * percentage / 100.00; 
		}

        public override string ToString()
        {
			return Name
				+ ", "
				+ "$"
				+ NetSalary().ToString("F2");
        }
    }
}

