using EternaTask.DataAccessLayer;
using EternaTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Page_Service> servicesp = await _context.Page_Services.ToListAsync();
            return View(servicesp);
        }
    }
}
