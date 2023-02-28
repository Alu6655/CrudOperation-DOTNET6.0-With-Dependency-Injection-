using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using Core.IDataContext;
namespace Core.Controllers
{
    public class HomeController : Controller
    {
        private IAnxiety_RegPatient _anx;

        public HomeController(IAnxiety_RegPatient anx)
        {
            _anx = anx;
        }

        public IActionResult Index()
        {
            return View(_anx.GetPatients());
        }

        public IActionResult Create()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Create(Anxiety_RegPatient reg)
        {
            _anx.AddPatients(reg);
            return RedirectToAction("Index", "Home");
        }
        
        public IActionResult Edit(int id)
        {
            var rs = _anx.GetPatientById(id);
            return View(rs[0]);
        }
        [HttpPost]
        public IActionResult Edit(Anxiety_RegPatient reg)
        {
            _anx.EditPatients(reg);
            return RedirectToAction("Index","Home");
        }

        public IActionResult Delete(int id)
        {
            _anx.DeletePatients(id);
            return RedirectToAction("Index", "Home");
        }

    }
}