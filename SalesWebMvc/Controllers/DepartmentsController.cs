using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Eletronics" });
            list.Add(new Department { Id = 2, Name = "Fashion" });
            list.Add(new Department { Id = 3, Name = "Foods", varX = 1 });
            list.Add(new Department { Id = 4, Name = "Teste"});
            return View(list);

            List<Teste> listB = new List<Teste>();

            List<Department> listA = new List<Department>();
            listA.Add(new Department { Id = 4, Email = "leomonte01@gmail.com" });


        }
    }
}