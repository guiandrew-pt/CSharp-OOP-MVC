﻿namespace ShoppingComposition.Entities
{
	public class OrderItem
	{
		public int Quantity { get; set; }
		public double Price { get; set; }
		public Product Product { get; set; } // One to one

        public OrderItem()
		{
		}

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Product.ProductName}, ${Price.ToString("F2")}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
        }
    }
}

