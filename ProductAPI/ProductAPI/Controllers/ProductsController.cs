using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _context.Products.ToList();
        }

        // POST
        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var existing = _context.Products.Find(id);
            if (existing == null) return NotFound();

            existing.Name = product.Name;
            existing.Price = product.Price;

            _context.SaveChanges();
            return Ok(existing);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();

            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }
    }
}