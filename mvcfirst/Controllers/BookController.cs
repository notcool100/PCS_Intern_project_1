using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcfirst.Models;

namespace mvcfirst.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Details()
        {
            var detail = books();
            return View(detail);
        }

        private Book books()
        {
            return new Book
            {
                Id = 1,
                Author = "anjal",
                Title = "My Love",
                PublishedYear = 2023
            };
        }
    }
}