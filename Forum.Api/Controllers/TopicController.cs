using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
