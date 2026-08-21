using Microsoft.AspNetCore.Mvc;

namespace NVT_CNTT2_LTW.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
