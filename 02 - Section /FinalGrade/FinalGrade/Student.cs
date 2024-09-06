namespace FinalGrade
{
	public class Student
	{
		// Properties:
		public string Name { get; set; }
		public double GradeA { get; set; }
		public double GradeB { get; set; }
        public double GradeC { get; set; }

		// Constructor:
        public Student(string name, double grade1, double grade2, double grade3)
		{
			Name = name;
			GradeA = grade1;
			GradeB = grade2;
			GradeC = grade3;
		}

		// Methods:
		public double FinalGrade()
		{
			return GradeA + GradeB + GradeC;
		}

		public bool Approved()
		{
			if (FinalGrade() > 60.0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public double Remaining()
		{
			if (Approved())
			{
				return 0.0;
			}
			else
			{
				return 60.0 - FinalGrade();
			}
		}

        public override string ToString()
        {
			return "Final Grade = "
				+ FinalGrade().ToString("F2");
        }
    }
}

