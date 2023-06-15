using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Elibrary3.Models;

namespace Elibrary3.contrllers
{
    public class homeController : Controller
    {
        private readonly ModelContext _context;
        public homeController(ModelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult register()
        {
            return View();
        }
        public IActionResult about()
            {
                return View();
            }
         public IActionResult contacts()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

    }
}