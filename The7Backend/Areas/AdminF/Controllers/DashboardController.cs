using Microsoft.AspNetCore.Mvc;

namespace The7Backend.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
