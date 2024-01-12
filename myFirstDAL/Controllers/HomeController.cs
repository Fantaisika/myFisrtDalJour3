using Microsoft.AspNetCore.Mvc;
using myFirstDAL.Models;

namespace myFirstDAL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ajout()
        {
            using (IDal maDal = new Dal())
            {
                maDal.CreerSejour("Perpignan", "0667584921");
            }
            return View("Index");
        }

        public IActionResult Sejours()
        {
            using (IDal maDal = new Dal())
            {
                ViewData["Sejours"] = maDal.ObtientTousLesSejours();
            }
            return View();
        }
    }
}
