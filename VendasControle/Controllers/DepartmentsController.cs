using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasControle.Models;

namespace VendasControle.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Farmacos" });
            list.Add(new Department { Id = 3, Name = "Moveis" });

            return View(list);
        }
    }
}
