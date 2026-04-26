using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderAPI.Models;
using OnlineFoodOrderAPI.Services;

namespace OnlineFoodOrderAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class FoodController : ControllerBase
    {
        private readonly FoodService _service = new FoodService();

        // Add food item
        [HttpPost("food")]
        public IActionResult AddFood(FoodItem food)
        {
            return Ok(_service.AddFood(food));
        }

        [HttpGet("foods")]
        public IActionResult GetFoods()
        {
            return Ok(_service.GetFoods());
        }

        // Place order
        [HttpPost("order")]
        public IActionResult PlaceOrder(List<OrderItem> items)
        {
            return Ok(_service.PlaceOrder(items));
        }

        // View orders
        [HttpGet("orders")]
        public IActionResult GetOrders()
        {
            return Ok(_service.GetOrders());
        }

        // Delete order
        [HttpDelete("order/{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var result = _service.DeleteOrder(id);

            if (result)
                return Ok("Order deleted successfully");

            return NotFound("Order not found");
        }
    }
}