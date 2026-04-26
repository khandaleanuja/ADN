using System.Collections.Generic;

namespace OnlineFoodOrderAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public double TotalBill { get; set; }
    }
}