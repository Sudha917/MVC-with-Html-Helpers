using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLhelpers.Models;

namespace HTMLhelpers.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            Main m = new Main();
            m.Name = "Sudha";
            List<SelectListItem> MyList = new List<SelectListItem>();

            MyList.Add(new SelectListItem { Value = "1", Text = "India", Selected = true });
            MyList.Add(new SelectListItem() { Value = "2", Text = "UK" });
            MyList.Add(new SelectListItem() { Value = "3", Text = "Dubai" });
           
            ViewData["Data"]= MyList;
            return View(m);
        }
    }
}