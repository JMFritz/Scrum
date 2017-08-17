using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scrum.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Scrum.Controllers
{
    public class TasksController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TasksController(ApplicationDbContext db) {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var thisTask = _db.Tasks.FirstOrDefault(t => t.TaskId == id);
            return View(thisTask);
        }
        [HttpPost, ActionName("Details")]
        public IActionResult Completed(int id)
        {
            var thisTask = _db.Tasks.FirstOrDefault(Tasks => Tasks.TaskId == id);
            if (thisTask.Complete)
            {
                thisTask.Complete = false;
            }
            else if (!(thisTask.Complete))
            {
                thisTask.Complete = true;
            }
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
        public IActionResult Create()
        {
            ViewBag.PhaseId = new SelectList(_db.Phases, "PhaseId", "Description");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Task task, int id)
        {
            task.Project = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
            task.Complete = false;
            _db.Tasks.Add(task);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
        }
    }
}
