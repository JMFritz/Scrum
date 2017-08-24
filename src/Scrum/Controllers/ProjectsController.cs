using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Scrum.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public async Task<IActionResult> Details(int Id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var currentUserId = currentUser.Id;
            ViewBag.CurrentUser = currentUser.UserName;
            ViewBag.Tasks = _db.Tasks.Where(t => t.UserId == currentUserId);
            var thisProject = _db.Projects.Include(projects => projects.Updates).Include(projects => projects.UserStories).Include(projects => projects.ProjectTools).Include(projects => projects.UserProjects).Include(projects => projects.Sprints).FirstOrDefault(projects => projects.ProjectId == Id);
            List<string> teamMembers = new List<string>() { };
            foreach(var join in thisProject.UserProjects)
            {
                var currentMember = await _userManager.FindByIdAsync(join.UserId);
                teamMembers.Add(currentMember.UserName);
            }
            ViewBag.Team = teamMembers;
            ViewBag.ToolId = new SelectList(_db.Tools, "ToolId", "Name");
            var sprints = _db.Sprints.Where(s => s.Project == thisProject);
            double dayCount = 0;
            List<SprintData> sprintDayCounts = new List<SprintData>();
            foreach (var sprint in sprints)
            {
                dayCount += (sprint.EndDate - sprint.StartDate).TotalDays;
            }
            foreach (var sprint in sprints)
            {
                var newSprintData = new SprintData();
                double sprintDays = (Math.Round((((sprint.EndDate - sprint.StartDate).TotalDays) / dayCount) * 100));
                newSprintData.Name = sprint.Name;
                newSprintData.Total = sprintDays;
                sprintDayCounts.Add(newSprintData);
            }
            ViewBag.SprintTotal = dayCount;
            ViewBag.SprintCollection = sprintDayCounts;
            return View(thisProject);
        }
        [HttpPost, ActionName("Details")]
        public IActionResult AddTool(int toolId, int id)
        {
            var thisProject = _db.Projects.Include(projects => projects.Updates).Include(projects => projects.ProjectTools).Include(projects => projects.Sprints).FirstOrDefault(projects => projects.ProjectId == id);
            var newTool = _db.Tools.FirstOrDefault(tools => tools.ToolId == toolId);
            var newProjectTool = new ProjectTool();
            newProjectTool.ProjectId = id;
            newProjectTool.ToolId = toolId;
            _db.ProjectTools.Add(newProjectTool);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
        public IActionResult AddUser(int id)
        {
            ViewBag.UserId = new SelectList(_db.Users, "Id", "UserName");
            return View();
        }
        [HttpPost, ActionName("AddUser")]
        public IActionResult AddUserPost(int id, string userId)
        {
            var assignedUser = _db.Users.FirstOrDefault(u => u.Id == userId);
            var newUserProject = new UserProject();
            newUserProject.ProjectId = id;
            newUserProject.UserId = assignedUser.Id;
            _db.UserProjects.Add(newUserProject);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
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
            DateTime timestamp = DateTime.Now;
            project.StartDate = timestamp;
            project.user = currentUser;
            _db.Projects.Add(project);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
