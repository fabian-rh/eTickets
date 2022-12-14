using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers {
    public class MoviesController : Controller {

        private readonly AppDBContext _context;

        public MoviesController(AppDBContext context) {
            _context = context;
        }
        public async Task<IActionResult> Index() {

            var allMovies = await _context.movies.ToListAsync();

            return View();
        }
    }
}
