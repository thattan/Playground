using Bogus;
using Microsoft.AspNetCore.Mvc;
using Playground.Data;
using Playground.Models;
using Playground.Models.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Controllers
{
    public class OrganizationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrganizationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrganizationList()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var list = _context.Organizations.ToList();
                //var list2 = new List<OrganizationModel>();
                //foreach (var item in list)
                //{
                //    list2.Add(new OrganizationModel()
                //    {
                //        Id = item.Id.ToString(),
                //        Name = item.Name,
                //        Mission = item.Mission,
                //        CreatedDate = item.CreatedDate
                //    }); 
                //}


                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    //list = list.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    list = list.Where(m => m.Name.Contains(searchValue) || m.Mission.Contains(searchValue)).ToList();
                }

                //total number of rows count   
                recordsTotal = list.Count();
                //Paging   
                var data = list.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new Organization();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Organization model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model = _context.Organizations.Add(model).Entity;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddFake()
        {

            var fake = new Faker<Organization>()
                .RuleFor(u => u.Name, f => f.Company.CompanyName())
                .RuleFor(u => u.Mission, f => f.Company.CatchPhrase())
                .Generate();

            var model = new Organization()
            {
                Name = fake.Name,
                Mission = fake.Mission,
                CreatedDate = DateTime.Now
            };

            model = _context.Organizations.Add(model).Entity;
            _context.SaveChanges();

            return View("Index");
        }

        [HttpGet]
        public IActionResult Add100Fake()
        {
            var list = new List<Organization>();
            for (int i = 0; i < 100; i++)
            {
                var fake = new Faker<Organization>()
                    .RuleFor(u => u.Name, f => f.Company.CompanyName())
                    .RuleFor(u => u.Mission, f => f.Company.CatchPhrase())
                    .Generate();

                var model = new Organization()
                {
                    Name = fake.Name,
                    Mission = fake.Mission,
                    CreatedDate = DateTime.Now
                };
                list.Add(model);
            }


            _context.Organizations.AddRange(list);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
