using Microsoft.AspNetCore.Mvc;
using myFirstDAL.Models;
using myFirstDALNet.ViewModels;
using System;

namespace myFirstDAL.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            

            HomeViewModel indexViewModel = new HomeViewModel
            {
                Message = "Bonjour tout le monde",
                Date = DateTime.Now,
                Sejour = new Sejour { Lieu = "Chambord", Telephone = "11111111" }
            };

            return View(indexViewModel);
        }



        public IActionResult Ajout()
        {
            using (IDal maDal = new Dal())
            {
                maDal.CreerSejour("Perpignan", "0667584921");
            }
            return View("Index");
        }

      

        public IActionResult Modifier()
        {
            using (IDal maDal = new Dal())
            {
                maDal.UpdateSejour(1, "Toulouse", "0667584921");
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
