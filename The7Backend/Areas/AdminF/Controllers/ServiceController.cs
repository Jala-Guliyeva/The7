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
    public class ServiceController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public ServiceController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env=env;
        }

        public IActionResult Index()
        {
            List<Service> service = _context.Services.ToList();

            return View(service);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Service dbService = await _context.Services.FindAsync(id);
             if(dbService==null)return NotFound();
            return View(dbService);

        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            Service dbService = await _context.Services.FindAsync(id);
            if (dbService == null) return NotFound();
            _context.Services.Remove(dbService);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Service service)
        {
            //validationstate-requiredolanlar
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();

            }

            if (service.Photo.IsImage())
            {
                if (service.Photo.ImageSize(10000))
                {
                    ModelState.AddModelError("Photo", "1mq yuxari olabilmez!");

                    return View();
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }
                bool isExistName = _context.Blogs.Any(c => c.Title.ToLower() == service.Title.ToLower());
                if (isExistName)
                {
                    ModelState.AddModelError("Name", "Eyni adlı kategoriya mövcuddur.");
                    return View();
                }
                //string path = @"C:\Users\TOSHIBA\Desktop\FiorelloAdminF\FiorelloTask\wwwroot\img\";

                string fileName = await service.Photo.SaveImage(_env, "assets/images");
                Service newService = new Service();
                newService.Desc = service.Desc;
                newService.Title = service.Title;
                newService.Image = fileName;
                await _context.Services.AddAsync(newService);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Photo", "Accept only image!");

            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Service dbService = await _context.Services.FindAsync(id);
            if (dbService == null) return NotFound();

            return View(dbService);



        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Service service)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Service dbService = await _context.Services.FindAsync(id);


            if (dbService == null) return NotFound();
            dbService.Title = service.Title;
            dbService.Desc = service.Desc;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
