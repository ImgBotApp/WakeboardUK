using Microsoft.AspNetCore.Mvc;

namespace WakeboardUK.Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}