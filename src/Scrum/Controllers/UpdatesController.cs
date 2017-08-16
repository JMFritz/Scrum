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
    public class UpdatesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public UpdatesController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Projects.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Update update, int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            update.Project = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
            update.User = currentUser;
            DateTime timestamp = DateTime.Now;
            update.TimeStamp = timestamp;
            _db.Updates.Add(update);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
        }
    }
}
