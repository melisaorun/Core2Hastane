using Core2Hastane.Data;
using Core2Hastane.model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core2Hastane.Controllers
{
    public class PolikliniklerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PolikliniklerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Poliklinikler.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Poliklinikler poliklinikler)
        {
            _db.Poliklinikler.Add(poliklinikler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = _db.Poliklinikler.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Poliklinikler poliklinikler)
        {
            _db.Update(poliklinikler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _db.Poliklinikler.Find(id);
            _db.Poliklinikler.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
