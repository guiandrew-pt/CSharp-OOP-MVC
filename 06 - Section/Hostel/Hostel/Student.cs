namespace Hostel
{
    public class Student
	{
		// Properties:
		public string Name { get; set; }
		public string Email { get; set; }

		// Constructor:
		public Student(string name, string email)
		{
			Name = name;
			Email = email;
		}

        //
        public override string ToString()
        {
			return Name + ", " + Email;
        }
    }
}

