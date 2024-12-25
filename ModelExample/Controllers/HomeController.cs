using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelExample.Models;
using ModelExample.Repository;


namespace ModelExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentRepository _studentRepository=null;
        private object rollNo;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository= new StudentRepository();
        }

        public List<StudentModel> getAllStudents()
        { 
        return _studentRepository.getAllStudents();
        
        }

        public StudentModel getStudentById(int id)
        {
            return _studentRepository.getStudentById(id);
        }


        public IActionResult Index()
        {
          //var students = new List<StudentModel>
          //{ new StudentModel{rollNo=1, name="Akshay",gender="Male", Standard=12 },
          //  new StudentModel{rollNo=2, name="Rahul",gender="Male", Standard=12 },
          //  new StudentModel{rollNo=3, name="Pranay",gender="Male", Standard=10 },
          //  new StudentModel{rollNo=4, name="Pushpa",gender="FeMale", Standard=12 },
          //  new StudentModel{rollNo=5, name="Ashwin",gender="Male", Standard=10 }
          //};

          //  ViewData["data1"] = students;


            return View();
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
