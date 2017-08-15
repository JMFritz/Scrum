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
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProjectsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Projects.ToList());
        }
        public IActionResult Details(int Id)
        {
            var thisProject = _db.Projects.FirstOrDefault(projects => projects.ProjectId == Id);
            return View(thisProject);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            project.user = currentUser;
            _db.Projects.Add(project);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
