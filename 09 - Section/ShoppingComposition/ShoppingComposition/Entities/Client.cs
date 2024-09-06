namespace ShoppingComposition.Entities
{
	public class Client
	{
		public string ClientName { get; set; }
		public string Email { get; set; }
		public DateTime	BirthDate { get; set; }

        public Client()
		{
		}

        public Client(string clientName, string email, DateTime birthDate)
        {
            ClientName = clientName;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{ClientName} ({BirthDate.ToString("dd/MM/yyy")}) - {Email}";
        }
    }
}

