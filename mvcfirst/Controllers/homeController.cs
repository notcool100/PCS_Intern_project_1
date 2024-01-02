using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using mvcfirst.Models;

namespace mvcfirst.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult contact()
        {
            var data = world();
            return View(data);
        }
        private detail world() {
            return new detail
            {
                Id = 1,
                Name = "Anjal",
                surname = "joshi"
            };
        }
    }

}