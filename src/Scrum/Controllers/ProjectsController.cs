﻿using System;
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
        public IActionResult Details(int Id)
        {
            var thisProject = _db.Projects.Include(projects => projects.Updates).Include(projects => projects.UserStories).Include(projects => projects.ProjectTools).Include(projects => projects.Sprints).FirstOrDefault(projects => projects.ProjectId == Id);
            ViewBag.ToolId = new SelectList(_db.Tools, "ToolId", "Name");
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
