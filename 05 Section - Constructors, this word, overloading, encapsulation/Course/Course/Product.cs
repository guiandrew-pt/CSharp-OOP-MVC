using System;
namespace Course
{
	public class Product
	{
		// Variables:
		public string Name;
		public double Price;
		public int Amount;

        // Constructor
        public Product()
        {
            Amount = 10;
        }

        public Product(string name, double price) : this()
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, int amount) : this(name, price)
		{
			Amount = amount;
		}

        // Methods:
        public double TotalAmountStock()
		{
			return Price * Amount;
		}

		public void AddStock(int amount)
		{
			Amount += amount;
		}

		public void RemoveStock(int amount)
        {
            Amount -= amount;
        }

        public override string ToString()
        {
			return Name
				+ ", $ "
				+ Price.ToString("F2")
				+ ", "
				+ Amount
				+ " units, total: $"
				+ TotalAmountStock().ToString("F2");
        }
    }
}

