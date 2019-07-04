using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jule02.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace jule02

{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Alldata dt = new Alldata { Groups = Datab.GetGroups(), Professions = Datab.GetProfessions(), Students=Datab.GetStudents() };

            return View(dt);
        }
        public IActionResult Group(int id)
        {
            
            ViewBag.Idd = id;
            Alldata dt = new Alldata { Groups = Datab.GetGroups(), Professions = Datab.GetProfessions(), Students = Datab.GetStudents() };
            return View(dt);
        }
    }
}
