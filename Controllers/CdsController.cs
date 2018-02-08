using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CdOrganizer.Models;

namespace CdOrganizer.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Cd> myCds = Cd.GetAll();
            return View(myCds);
        }

        [HttpGet("/cd/add")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/")]
        public ActionResult Create()
        {
            Cd newCd = new Cd (Request.Form["title"], Request.Form["artist"]);
            newCd.Save();
            List<Cd> allCds = Cd.GetAll();
            return View("Index", allCds);

        }
    }
}
