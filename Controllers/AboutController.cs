using EternaTask.DataAccessLayer;
using EternaTask.Models;
using EternaTask.ViewModels.AboutVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients=await _context.Clients.ToListAsync();
            List<Testimonial> tesimonials= await _context.Testimonials
                .Include(t => t.Position)
                .ToListAsync();   

            IndexVM viewmodel= new IndexVM
            {
                _clients=clients,
                _testimonials=tesimonials
            };

            return View(viewmodel);
        }
    }
}
