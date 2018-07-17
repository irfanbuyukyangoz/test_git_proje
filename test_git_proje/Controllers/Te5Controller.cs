using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test_git_proje.Controllers
{
    public class Te5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MvcMerhaba()
        {
            return View();
        }
    }
}