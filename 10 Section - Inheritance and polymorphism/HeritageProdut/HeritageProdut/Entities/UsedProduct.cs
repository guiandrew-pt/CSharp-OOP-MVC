namespace HeritageProdut.Entities
{
	public class UsedProduct : Product
	{
		public DateTime ManufactureDate { get; set; }

		public UsedProduct()
		{
		}

        public UsedProduct(string productName, double price, DateTime manufactureDate) : base(productName, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{ProductName} (used) ${Price.ToString("F2")} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}

