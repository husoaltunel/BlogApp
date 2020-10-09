using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs.Select(b => new BlogModel
                {
                    Id = b.Id,
                    Title = b.Title.Length > 100 ? b.Title.Substring(0,100) + "..." : b.Title,
                    Description = b.Description,
                    UploadDate = b.UploadDate,
                    Home = b.Home,
                    Confirmation = b.Confirmation,
                    Photo = b.Photo
                }).Where(b => b.Confirmation == true && b.Home == true);
                
            return View(blogs.ToList());
        }
    }
}