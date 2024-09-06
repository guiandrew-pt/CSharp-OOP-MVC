namespace SaleItems.Entities
{
	public class Product
	{
		public string ProductName { get; set; }
		public double Price { get; set; }
		public int Amount { get; set; }

        public Product(string productName, double price, int amount)
        {
            ProductName = productName;
            Price = price;
            Amount = amount;
        }

        public double Total()
        {
            return Price * Amount;
        }

        public override string ToString()
        {
            return $"{ProductName}, {Total().ToString("F2")}";
        }
    }
}

