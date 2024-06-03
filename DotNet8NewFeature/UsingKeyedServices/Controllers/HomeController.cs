using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsingKeyedServices.Models;
using UsingKeyedServices.Services;

namespace UsingKeyedServices.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShoppingCartService _shoppingCartService;

        public HomeController(ILogger<HomeController> logger, IShoppingCartService shoppingCartService)
        {
            _logger = logger;
            _shoppingCartService = shoppingCartService;
        }

        public IActionResult Index()
        {
            _shoppingCartService.ClearCart();
            return View();
        }


        public IActionResult Privacy([FromKeyedServices("push")] INotificationService notificationService)
        {
            notificationService.SendNotification("Error occurred!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
