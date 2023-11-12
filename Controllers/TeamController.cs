using EternaTask.DataAccessLayer;
using EternaTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;

        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Employee> employees=await _context.Employees
                .Include(e => e.position)
                .ToListAsync();
            return View(employees);
        }
    }
}
