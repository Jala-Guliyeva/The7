using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The7Backend.DAL;
using The7Backend.ViewModels;

namespace The7Backend.Controllers
{
    
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.sliders = _context.Sliders.FirstOrDefault();
            homeVM.services = _context.Services.ToList();
            homeVM.blogs = _context.Blogs.ToList();
            homeVM.teams = _context.Teams.ToList();
            return View(homeVM);
        }
    }
}
