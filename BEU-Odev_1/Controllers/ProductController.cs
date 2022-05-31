using BEU_Odev_1.Data;
using BEU_Odev_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_Odev_1.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IList<Product> ProductListesi = _db.Product.ToList();
            return View(ProductListesi);
        }
        public IActionResult Create()
        {

            return View();
        }

    
        [HttpPost]
        public IActionResult Create(Product o)
        {
            if (ModelState.IsValid)
            {
                _db.Add(o);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }

        }
    }
}
