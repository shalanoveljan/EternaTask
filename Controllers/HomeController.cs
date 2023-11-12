using EternaTask.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;

namespace EternaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
