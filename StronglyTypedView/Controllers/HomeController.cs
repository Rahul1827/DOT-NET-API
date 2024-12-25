using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedView.Models;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            //Employee employee = new Employee()
            //{ 
            //      empId=101,
            //      name="Rahul",
            //      designation="Enginner",
            //      salary=50000.00

            //};



            var myEmployees = new List<Employee>
    {
    new Employee {empId=101, name="Rahul",designation="Engineer",salary=500000.00 },
    new Employee {empId=102, name="Akshay",designation="Engineer",salary=600000.00 },
       new Employee {empId=103, name="Pradeep",designation="Engineer",salary=700000.00 },
          new Employee {empId=104, name="Pradunya",designation="Engineer",salary=800000.00 },
             new Employee {empId=105, name="Swapnil",designation="Engineer",salary=900000.00 },

    };



            ViewData["myEmployee"] = myEmployees;
            return View(myEmployees);
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
    }
}
