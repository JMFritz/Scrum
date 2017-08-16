using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scrum.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Scrum.Controllers
{
    public class UserStoriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserStoriesController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserStory userstory, int id)
        {
            userstory.Project = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
            _db.UserStories.Add(userstory);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
        }
    }
}
