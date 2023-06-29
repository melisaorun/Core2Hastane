using Core2Hastane.Data;
using Core2Hastane.model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core2Hastane.Controllers
{
    public class DoktorlarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DoktorlarController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Doktorlar.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doktorlar doktorlar)
        {
            _db.Doktorlar.Add(doktorlar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var update=_db.Doktorlar.Find(id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Edit(Doktorlar doktorlar)
        {
            _db.Update(doktorlar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delete = _db.Doktorlar.Find(id);
            _db.Doktorlar.Remove(delete);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
