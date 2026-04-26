using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger, IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index page accessed");

            string cacheKey = "myData";

            if (!_cache.TryGetValue(cacheKey, out DataModel data))
            {
                _logger.LogInformation("Data not in cache. Generating new data...");

                // Simulate slow operation
                data = new DataModel
                {
                    Message = "Data generated at:",
                    TimeGenerated = DateTime.Now
                };

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(30));

                _cache.Set(cacheKey, data, cacheOptions);
            }
            else
            {
                _logger.LogInformation("Data fetched from cache");
            }

            return View(data);
        }
    }
}