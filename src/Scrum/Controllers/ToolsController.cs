using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scrum.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Scrum.Controllers
{
    public class ToolsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public ToolsController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Tools.ToList());
        }
        public IActionResult Create()
        {
            ViewBag.ToolTypeId = new SelectList(_db.ToolTypes, "ToolTypeId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tool tool)
        {
            _db.Tools.Add(tool);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
