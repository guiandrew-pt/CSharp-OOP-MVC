namespace HeritageProdut.Entities
{
	public class ImportedProduct : Product
	{
		public double CustomFee { get; set; }

		public ImportedProduct()
		{

		}

        public ImportedProduct(string productName, double price, double customFee) : base(productName, price)
        {
			CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"ProductName ${TotalPrice().ToString("F2")} (Customs fee: ${CustomFee.ToString("F2")})";
        }

        public double TotalPrice()
		{
			return Price + CustomFee;
		}
    }
}

