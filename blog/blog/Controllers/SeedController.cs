using blog.Contexts;
using blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace blog.Controllers
{
    public class SeedController : Controller
    {
        // GET: Seed
        public ActionResult Index()
        {
            var userContext = new UserContext();

            var user = new List<User>();
            user.Add(new User
            {
                username = "test",
                passwordHash = "test"
            });

            user.ForEach(s => userContext.Users.Add(s));
            userContext.SaveChanges();
            ViewBag.Message = "Succesfully Seeded Users";

            return View();
        }
    }
}