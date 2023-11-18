using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Controllers
{
    public class DashboardController : Controller
    {
        
        public IActionResult Index()
        {
            Context c = new Context();

            var usermail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterId).FirstOrDefault();

            ViewBag.v1 = c.Blogs.Count().ToString();

            ViewBag.v2 = c.Blogs.Where(x=>x.WriterId==writerId).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}