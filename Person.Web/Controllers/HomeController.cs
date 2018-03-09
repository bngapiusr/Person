using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonDemo.Web.Models;
using PersonDemo.Web.ViewModels;

namespace PersonDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPeopleRepository _peoplerepo;

        public HomeController(IPeopleRepository peoplerepo)
        {
            _peoplerepo = peoplerepo;
        }
        // GET: Home
        public IActionResult Index()
        {
            var person = _peoplerepo.GetAllPerson().OrderBy(p => p.LastName);
            var homeviewmodel = new HomeViewModel()
            {
                People = person.ToList(),
                Title = "This is the Person Demo"
            };
            return View(homeviewmodel);
        }

        //// GET: Home/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Home/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Home/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Home/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Home/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Home/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Home/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}