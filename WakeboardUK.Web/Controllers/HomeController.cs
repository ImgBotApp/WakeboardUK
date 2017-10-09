using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WakeboardUK.Web.Data;
using WakeboardUK.Web.Models;

namespace WakeboardUK.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new MyViewModel();
            model.TopArticles = _context.Articles.OrderByDescending(t => t.CreateDate).Take(5).ToList();
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }

    public class MyViewModel
    {
        public List<Article> TopArticles { get; set; }
    }
}