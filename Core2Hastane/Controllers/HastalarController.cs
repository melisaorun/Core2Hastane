using Core2Hastane.Data;
using Core2Hastane.model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core2Hastane.Controllers
{
    public class HastalarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public HastalarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Hastalar.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hastalar hastalar)
        {
            _db.Hastalar.Add(hastalar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = _db.Hastalar.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Hastalar hastalar)
        {
            _db.Update(hastalar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _db.Hastalar.Find(id);
            _db.Hastalar.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
