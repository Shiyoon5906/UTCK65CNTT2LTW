using Microsoft.AspNetCore.Mvc;
using NVT_CNTT2_LTW.Models;

namespace NVT_CNTT2_LTW.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Mẫu 1", Price = 50000, CreatedAt = new DateTime(2026,8,21), Image = "Cay1.jpg" },
                new Product { Id = 2, Name = "Mẫu 2", Price = 70000, CreatedAt = new DateTime(2026,8,21), Image = "Cay2.jpg" },
                new Product { Id = 3, Name = "Mẫu 3", Price = 55000, CreatedAt = new DateTime(2026,8,21), Image = "Cay3.jpg" },
                new Product { Id = 4, Name = "Mẫu 4", Price = 55000, CreatedAt = new DateTime(2026,8,21), Image = "Cay4.jpg" }
            };

            return View(products);
        }
    }   
}
