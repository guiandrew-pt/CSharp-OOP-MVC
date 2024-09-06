using System.Text;
using ShoppingComposition.Entities.Enums;

namespace ShoppingComposition.Entities
{
	public class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }
		public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>(); // to many
		public Client Client { get; set; } // To one

        public Order()
		{
		}

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem item in OrderItems)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ORDER SUMMARY:");
            stringBuilder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            stringBuilder.AppendLine($"Order status: {Status}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order items:");

            foreach (OrderItem item in OrderItems)
            {
                stringBuilder.AppendLine($"{item.Product.ProductName}, ${item.Price.ToString("F2")}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal().ToString("F2")}");
            }
            stringBuilder.AppendLine($"Total price: ${Total().ToString("F2")}");
            return stringBuilder.ToString();
        }
    }
}

