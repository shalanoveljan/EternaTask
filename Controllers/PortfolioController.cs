using EternaTask.DataAccessLayer;
using EternaTask.Models;
using EternaTask.ViewModels.PortfolioVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;

        public PortfolioController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients = await _context.Clients.ToListAsync();
            List<Portfolio> portfolios = await _context.Portfolios
                .Include(p=>p.Category)
                .ToListAsync();
            PortfolioIndexVm viewmodel = new PortfolioIndexVm
            {
                _clients= clients,
                _portfolios= portfolios,
                _categories=await _context.Categories.ToListAsync()

            };

            return View(viewmodel);
        }
    }
}
