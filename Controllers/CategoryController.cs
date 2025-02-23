using Microsoft.AspNetCore.Mvc;

namespace WebMarket.Web.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
