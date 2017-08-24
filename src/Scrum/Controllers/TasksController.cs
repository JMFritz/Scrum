using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scrum.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.UserId = new SelectList(_db.Users, "Id", "UserName");
            string[] priorities = { "High", "Medium", "Low" };
            ViewBag.Priority = priorities;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Task task, int id)
        {
            task.Project = _db.Projects.FirstOrDefault(p => p.ProjectId == id);
            task.Complete = false;
            _db.Tasks.Add(task);
            _db.SaveChanges();
            return RedirectToAction("Details", "Projects", new { id = id });
        }
        public IActionResult Edit(int id)
        {
            ViewBag.PhaseId = new SelectList(_db.Phases, "PhaseId", "Description");
            var thisTask = _db.Tasks.FirstOrDefault(s => s.TaskId == id);
            return View(thisTask);
        }
        [HttpPost]
        public IActionResult Edit(Task task)
        {
            _db.Entry(task).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", "Tasks", new { id = task.TaskId });
        }

        public IActionResult Delete(int id)
        {
            var thisTask = _db.Tasks.Include(t => t.Sprint).FirstOrDefault(t => t.TaskId == id);
            return View(thisTask);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisTask = _db.Tasks.Include(t => t.Sprint).FirstOrDefault(t => t.TaskId == id);
            var link = thisTask.Sprint.SprintId;
            _db.Tasks.Remove(thisTask);
            _db.SaveChanges();
            return RedirectToAction("Details", "Sprints", new { id = link });
        }
    }
}
