using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
