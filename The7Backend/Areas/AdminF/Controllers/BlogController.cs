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
    public class BlogController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public BlogController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Blog> blog = _context.Blogs.ToList();
            return View(blog);
        }

        public async Task<IActionResult>Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog dbBlog =await _context.Blogs.FindAsync(id);
            if(dbBlog == null) return NotFound();
            return View(dbBlog);
        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog dbBlog =await  _context.Blogs.FindAsync(id);
            if (dbBlog == null) return NotFound();
            _context.Blogs.Remove(dbBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            //validationstate-requiredolanlar
            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();

            }

            if (blog.Photo.IsImage())
            {
                if (blog.Photo.ImageSize(10000))
                {
                    ModelState.AddModelError("Photo", "1mq yuxari olabilmez!");

                    return View();
                }

                if (!ModelState.IsValid)
                {
                    return View();
                }
                bool isExistName = _context.Blogs.Any(c => c.Title.ToLower() == blog.Title.ToLower());
                if (isExistName)
                {
                    ModelState.AddModelError("Name", "Eyni adlı kategoriya mövcuddur.");
                    return View();
                }
                //string path = @"C:\Users\TOSHIBA\Desktop\FiorelloAdminF\FiorelloTask\wwwroot\img\";

                string fileName = await blog.Photo.SaveImage(_env, "assets/images");
                Blog newBlog = new Blog();
                newBlog.Desc = blog.Desc;
                newBlog.Title = blog.Title;
                newBlog.Image = fileName;
                await _context.Blogs.AddAsync(newBlog);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            ModelState.AddModelError("Photo", "Accept only image!");

            return View();
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();

            Blog dbBlog = await _context.Blogs.FindAsync(id);
            if (dbBlog == null) return NotFound();

            return View(dbBlog);



        }
        [HttpPost]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Blog dbBlog = await _context.Blogs.FindAsync(id);
           
            
            if (dbBlog == null) return NotFound();
            dbBlog.Title = blog.Title;
            dbBlog.Desc = blog.Desc;
            dbBlog.Profession = blog.Profession;
            dbBlog.Time = blog.Time;
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
