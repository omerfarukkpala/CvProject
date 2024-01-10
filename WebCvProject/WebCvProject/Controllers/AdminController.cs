using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCvProject.Models.Entity;
using WebCvProject.Repositories;

namespace WebCvProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<TblAdmin> repo = new GenericRepository<TblAdmin>();

        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
    }
}