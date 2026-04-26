using System.Collections.Generic;
using OnlineFoodOrderAPI.Models;

namespace OnlineFoodOrderAPI.Data
{
    public static class InMemoryDb
    {
        public static List<FoodItem> Foods = new List<FoodItem>();
        public static List<Order> Orders = new List<Order>();
    }
}