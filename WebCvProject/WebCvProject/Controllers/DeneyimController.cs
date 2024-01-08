using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCvProject.Repositories;

namespace WebCvProject.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();

        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
    }
}