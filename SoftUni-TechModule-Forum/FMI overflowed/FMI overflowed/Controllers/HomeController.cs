using FMI_overflowed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace FMI_overflowed.Controllers
{
    public class HomeController : Controller
    {
        //paste the db from where 
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var latestPost = db.Post.Include(p => p.Author).OrderByDescending(p => p.Date).Take(1);
            return View(latestPost);
        }

        public ActionResult MathPosts()
        {
            var db = new ApplicationDbContext();
            var post = db.Post.OrderByDescending(p => p.Date).Take(15);
            return View(post.ToList());
        }
        public ActionResult ProgrammingPosts()
        {
            var db = new ApplicationDbContext();
            var post = db.Post.OrderByDescending(p => p.Date).Take(15);
            return View(post.ToList());
        }

        public ActionResult FunPosts()
        {
            var db = new ApplicationDbContext();
            var post = db.Post.OrderByDescending(p => p.Date).Take(15);
            return View(post.ToList());
        }

    }
}