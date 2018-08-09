using System;
using System.Collections.Generic;
using Sparta_Blog_Project.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparta_Blog_Project.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog b)
        {
            if(ModelState.IsValid)
            {
                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Blogs.Add(b);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}