using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    public class StandardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
