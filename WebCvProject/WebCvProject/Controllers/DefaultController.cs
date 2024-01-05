using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCvProject.Models.Entity;

namespace WebCvProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbCvEntities db = new DbCvEntities();

        public ActionResult Index()
        {
            var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TblSosyalMedya.Where(x => x.Durum == true).ToList();
            return PartialView(sosyalmedya);
        }
    }
}