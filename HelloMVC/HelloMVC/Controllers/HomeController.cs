using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MessageModel
            {
                Message = "Hello, Welcome to ASP.NET Core MVC!"
            };

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = HttpContext.TraceIdentifier
            });
        }
    }
}