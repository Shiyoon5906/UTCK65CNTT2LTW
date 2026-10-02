using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NVTu_LESSON07.Controllers
{
    public class NvtMember : Controller
    {
        private static List<NvtMember> nvtMembers = new List<NvtMember>();
        // GET: NvtMember
        public ActionResult Index()
        {
            return View(nvtMembers);
        }

        // GET: NvtMember/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NvtMember/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NvtMember/Create
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

        // GET: NvtMember/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NvtMember/Edit/5
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

        // GET: NvtMember/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NvtMember/Delete/5
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
