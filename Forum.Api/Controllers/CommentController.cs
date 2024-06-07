using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
