using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Playground.Data;
using Playground.Models;

namespace Playground.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DataTableTest()
        {

            return View();
        }

        [HttpPost]
        public IActionResult DataTableCall()
        {
            return Json(new { header1 = "test 1", header2 = "test 2", header3 = "test 3" });
        }

        public async Task<IActionResult> TaskList()
        {

            var taskList = _context.Tasks.AsQueryable().Where(x => !x.Complete).OrderBy(x => x.Order).ToList();

            return PartialView("_task-list", taskList);

        }

        public IActionResult AddTask(string data)
        {
            _context.Tasks.Add(new Data.Task()
            {
                Text = data,
                Complete = false
            });
            _context.SaveChanges();

            return Ok();
        }

        public IActionResult SaveTasks(List<Data.Task> list)
        {
            _context.UpdateRange(list);
            _context.SaveChanges();

            return Ok();
        }
    }
}
