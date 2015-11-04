using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChat.Controllers
{
    public class BookController : Controller
    {

        mvc5Entities db = new mvc5Entities();

        // GET: Book
        public ActionResult Index()
        {
            var book = from b in db.book
                       where b.Author != ""
                       select b;

            return View(book.ToList());
        }
    }
}