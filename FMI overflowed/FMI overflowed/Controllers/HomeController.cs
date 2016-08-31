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
            var db = new ApplicationDbContext();
            var post = db.Post.OrderByDescending(p => p.Date).Take(100);
            return View(post.ToList());
        }

        public ActionResult MathPosts(string searchString)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.Include(p => p.Author).OrderByDescending(p => p.Date).Take(15);

            if (!String.IsNullOrEmpty(searchString))
            {
                post = post.Where(s => s.Title.Contains(searchString));
            }

            return View(post.ToList());
        }
        public ActionResult ProgrammingPosts(string searchString)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.Include(p => p.Author).OrderByDescending(p => p.Date).Take(15);

            if (!String.IsNullOrEmpty(searchString))
            {
                post = post.Where(s => s.Title.Contains(searchString));
            }

            return View(post.ToList());
        }

        public ActionResult FunPosts(string searchString)
        {
            var db = new ApplicationDbContext();
            var post = db.Post.Include(p => p.Author).OrderByDescending(p => p.Date).Take(15);       

            if (!String.IsNullOrEmpty(searchString))
            {
                post = post.Where(s => s.Title.Contains(searchString));
            }
            return View(post.ToList());
        }

    }
}