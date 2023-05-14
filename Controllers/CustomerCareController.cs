using Microsoft.AspNetCore.Mvc;

namespace CustomerCareModule.Controllers
{
    public class CustomerCareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
