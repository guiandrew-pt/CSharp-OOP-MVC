using System;
namespace AverageSalary
{
	public class Employee
	{
		// Properties:
		public string Name { get; set; }
		public double Salary { get; set; }

		// Construtor:
        public Employee(string name, double salary)
		{
			Name = name;
			Salary = salary;
		}
	}
}

