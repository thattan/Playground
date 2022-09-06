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
    public class StarWarsController : Controller
    {
        public StarWarsController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
