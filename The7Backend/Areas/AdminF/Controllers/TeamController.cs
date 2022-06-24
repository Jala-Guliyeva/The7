using FiorelloTask.Extentions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The7Backend.DAL;
using The7Backend.Models;

namespace The7Backend.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    public class TeamController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public TeamController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList();
            return View(teams);
        }
        public async Task<IActionResult>Detail(int? id)
        {
            if (id == null) return NotFound();
            Team dbTeam = await _context.Teams.FindAsync(id);
            if (dbTeam == null) return NotFound();
            return View(dbTeam);
        }
        public async Task<IActionResult>Delete(int? id)
        {

            if (id == null) return NotFound();
            Team dbTeam = await _context.Teams.FindAsync(id);
            if (dbTeam == null) return NotFound();
            _context.Teams.Remove(dbTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Team team)
        {
            //validationstate-requiredolanlar
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();

            }

            if (team.Photo.IsImage())
            {
                if (team.Photo.ImageSize(10000))
                {
                    ModelState.AddModelError("Photo", "1mq yuxari olabilmez!");

                    return View();
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }
                bool isExistName = _context.Teams.Any(c => c.Author.ToLower() == team.Author.ToLower());
                if (isExistName)
                {
                    ModelState.AddModelError("Name", "Eyni adlı author mövcuddur.");
                    return View();
                }
                //string path = @"C:\Users\TOSHIBA\Desktop\FiorelloAdminF\FiorelloTask\wwwroot\img\";

                string fileName = await team.Photo.SaveImage(_env, "img");
                Team newTeam = new Team();
                newTeam.Author = team.Author;
                newTeam.Image = fileName;
                await _context.Teams.AddAsync(newTeam);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Photo", "Accept only image!");

            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Team dbTeam = await _context.Teams.FindAsync(id);
            if (dbTeam == null) return NotFound();

            return View(dbTeam);



        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Team team)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Team dbTeam = await _context.Teams.FindAsync(id);


            if (dbTeam == null) return NotFound();
            dbTeam.Author = team.Author;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
