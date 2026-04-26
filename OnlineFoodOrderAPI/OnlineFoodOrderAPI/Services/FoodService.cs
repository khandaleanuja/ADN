using OnlineFoodOrderAPI.Data;
using OnlineFoodOrderAPI.Models;

namespace OnlineFoodOrderAPI.Services
{
    public class FoodService
    {
        // Add Food
        public FoodItem AddFood(FoodItem food)
        {
            InMemoryDb.Foods.Add(food);
            return food;
        }

        public List<FoodItem> GetFoods()
        {
            return InMemoryDb.Foods;
        }

        // Place Order + Calculate Bill
        public Order PlaceOrder(List<OrderItem> items)
        {
            double total = 0;

            foreach (var item in items)
            {
                var food = InMemoryDb.Foods.Find(f => f.Id == item.FoodId);

                if (food != null)
                {
                    total += food.Price * item.Quantity;
                }
            }

            var order = new Order
            {
                Id = InMemoryDb.Orders.Count + 1,
                Items = items,
                TotalBill = total
            };

            InMemoryDb.Orders.Add(order);
            return order;
        }

        // Get Orders
        public List<Order> GetOrders()
        {
            return InMemoryDb.Orders;
        }

        // Delete Order
        public bool DeleteOrder(int id)
        {
            var order = InMemoryDb.Orders.Find(o => o.Id == id);

            if (order != null)
            {
                InMemoryDb.Orders.Remove(order);
                return true;
            }

            return false;
        }
    }
}