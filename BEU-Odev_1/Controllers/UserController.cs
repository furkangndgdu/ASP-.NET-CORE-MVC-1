using BEU_Odev_1.Data;
using BEU_Odev_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BEU_Odev_1.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            IList<User> UserListesi = _db.User.ToList();
            return View(UserListesi);
        }
       
        public IActionResult Create()
        {

            return View();
        }

        
        [HttpPost]
        public IActionResult Create(User o)
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
