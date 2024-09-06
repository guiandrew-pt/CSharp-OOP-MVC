namespace Balance
{
	public class Account
	{
		// Properties:
		public int Number { get; private set; }
		public string Holder { get; set; }
		public double Balance { get; private set; }

		// Constructores:
		public Account(int number, string holder)
		{
			Number = number;
            Holder = holder;
			Balance = 0.0;
		}

        public Account(int number, string holder, double inicialDeposit) : this(number, holder)
        {
			Deposit(inicialDeposit);
        }

        // Methods:
        public void Deposit(double amount)
		{
			Balance += amount;
		}

		public void Withdraw(double amount)
		{
            Balance -= amount + 5.00;
        }

        public override string ToString()
        {
			return "Account "
				+ Number
				+ ", Holder: "
				+ Holder
				+ ", Balance: $"
				+ Balance.ToString("F2");
        }
    }
}

