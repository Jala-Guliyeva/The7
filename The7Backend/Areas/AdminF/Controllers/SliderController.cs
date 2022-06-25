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
    public class SliderController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;


        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env=env;
        }

        public IActionResult Index()
        {
            List<Slider> slider = _context.Sliders.ToList();
            return View(slider);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Slider dbSlider =await  _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();
            return View(dbSlider);
        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider dbSlider = await _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();
            _context.Sliders.Remove(dbSlider);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            //validationstate-requiredolanlar
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();

            }

            if (slider.Photo.IsImage())
            {
                if (slider.Photo.ImageSize(10000))
                {
                    ModelState.AddModelError("Photo", "1mq yuxari olabilmez!");

                    return View();
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }
                bool isExistName = _context.Blogs.Any(c => c.Title.ToLower() == slider.Title.ToLower());
                if (isExistName)
                {
                    ModelState.AddModelError("Name", "Eyni adlı kategoriya mövcuddur.");
                    return View();
                }
                //string path = @"C:\Users\TOSHIBA\Desktop\FiorelloAdminF\FiorelloTask\wwwroot\img\";

                string fileName = await slider.Photo.SaveImage(_env, "assets/images");
                Slider newSlider = new Slider();
                newSlider.Desc = slider.Desc;
                newSlider.Title = slider.Title;
                newSlider.Image = fileName;
                await _context.Sliders.AddAsync(newSlider);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Photo", "Accept only image!");

            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Slider dbSlider = await _context.Sliders.FindAsync(id);
            if (dbSlider == null) return NotFound();

            return View(dbSlider);



        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Slider dbSlider = await _context.Sliders.FindAsync(id);


            if (dbSlider == null) return NotFound();
            dbSlider.Title = slider.Title;
            dbSlider.Desc = slider.Desc;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
