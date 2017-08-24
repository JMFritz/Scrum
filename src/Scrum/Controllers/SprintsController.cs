using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Scrum.Models;

namespace Scrum.Controllers
{
    public class SprintsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SprintsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            var thisSprint = _db.Sprints.Include(s => s.Tasks).Include(s => s.Updates).Include(s => s.Project).Include(s => s.Project.Tasks).FirstOrDefault(s => s.SprintId == Id);
            var thisProject = thisSprint.Project;
            var count = 0;
            foreach (var task in thisSprint.Tasks)
            {
                if (task.Complete)
                {
                    count++;
                }
            }
            int max = thisSprint.Tasks.Count;
            var currentPercent = Math.Round(((double)count / (double)max) * 100);
            var taskList = _db.Tasks.Where(t => t.Project == thisProject);
            ViewBag.TaskId = new SelectList(taskList, "TaskId", "Description");
            ViewBag.Current = currentPercent;
            return View(thisSprint);
        }
        [HttpPost, ActionName("Details")]
        public IActionResult AddTask(int TaskId, int id)
        {
            var thisTask = _db.Tasks.Include(t => t.Sprint).FirstOrDefault(t => t.TaskId == TaskId);
            thisTask.Sprint = _db.Sprints.FirstOrDefault(s => s.SprintId == id);
            _db.SaveChanges();
            return RedirectToAction("Details");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Sprint sprint, int id)
        {
            sprint.Project = _db.Projects.FirstOrDefault(projects => projects.ProjectId == id);
            _db.Sprints.Add(sprint);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
        }
    }
}
