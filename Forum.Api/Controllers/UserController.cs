using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
