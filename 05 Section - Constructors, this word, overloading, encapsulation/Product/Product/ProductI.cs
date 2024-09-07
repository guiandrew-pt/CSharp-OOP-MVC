using System.Xml.Linq;

namespace Product
{
	public class ProductI
	{
        // Variables:
        private string _name;

        // Properties:
        public double Price { get; private set; }
        public int Amount { get; private set; }
        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        // Constructor
        public ProductI()
        {
        }

        public ProductI(string name, double price, int amount)
        {
            _name = name;
            Price = price;
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
            return _name
                + ", $ "
                + Price.ToString("F2")
                + ", "
                + Amount
                + " units, total: $"
                + TotalAmountStock().ToString("F2");
        }
    }
}

