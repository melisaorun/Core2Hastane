using Core2Hastane.Data;
using Core2Hastane.model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core2Hastane.Controllers
{
    public class RandevularController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RandevularController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Randevular.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Randevular randevular)
        {
            _db.Randevular.Add(randevular);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update = _db.Randevular.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Randevular randevular)
        {
            _db.Update(randevular);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _db.Randevular.Find(id);
            _db.Randevular.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
