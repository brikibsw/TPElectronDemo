using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TPElectronDemo.Data;
using TPElectronDemo.Models;

namespace TPElectronDemo.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;
        private readonly TestDbContext dbContext;

        public DemoController(ILogger<DemoController> logger, TestDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = dbContext.Countries.ToList();

            return View(data);
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
