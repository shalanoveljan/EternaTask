using EternaTask.DataAccessLayer;
using EternaTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaTask.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Article> articles = await _context.Articles.ToListAsync();

            return View(articles);
        }

        public async Task<IActionResult> Detail(int? id)
        {


            if (id == null)
            {
                return BadRequest();
            }

            Article? article = await _context.Articles
                .FirstOrDefaultAsync(c => c.Id == id);
            if (article == null)
            {
                return NotFound();
            }
           

            return View(article);
        }
    }
}
