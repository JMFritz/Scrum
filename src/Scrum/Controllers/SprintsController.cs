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
            var thisSprint = _db.Sprints.Include(s => s.Tasks).Include(s => s.Updates).FirstOrDefault(s => s.SprintId == Id);
            return View(thisSprint);
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
