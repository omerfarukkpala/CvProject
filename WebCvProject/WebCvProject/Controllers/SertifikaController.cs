using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCvProject.Models.Entity;
using WebCvProject.Repositories;

namespace WebCvProject.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TblSertifikalarim> repo = new GenericRepository<TblSertifikalarim>();
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            return View(sertifika);
        }
    }
}