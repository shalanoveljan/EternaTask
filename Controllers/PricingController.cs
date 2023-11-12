using EternaTask.DataAccessLayer;
using EternaTask.Models;
using EternaTask.ViewModels.AboutVMs;
using EternaTask.ViewModels.PricingVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;

        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Pricing> pricings = await _context.Pricings
           .Include(p => p.PricingServices)
           .ThenInclude(ps => ps.Service)
           .ToListAsync();

            PricingIndexVM viewModel = new PricingIndexVM();
            viewModel._pricings = await _context.Pricings
                .Include(p => p.PricingServices)
                .ThenInclude(ps => ps.Service)
                .ToListAsync();
            viewModel._services = await _context.Services.ToListAsync();



            return View(viewModel);
        }
    }
}
