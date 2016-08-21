using FMI_overflowed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMI_overflowed.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult MathPosts()
        {
            var db = new ApplicationDbContext();
            var post = db.Post.OrderByDescending(p => p.Date).Take(3);
            return View(post.ToList());
        }
        public ActionResult ProgrammingPosts()
        {
            return View();
        }

        public ActionResult FunPosts()
        {
            return View();
        }

    }
}