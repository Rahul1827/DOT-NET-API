using AspNetCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Student> student = new List<Student>() { 
            
            new Student{studentId=101, name="Pranay" ,gender="Male"},
            new Student{studentId=102, name="Sakshi" ,gender="FeMale"},
            new Student{studentId=103, name="Samarth" ,gender="Male"},
            new Student{studentId=104, name="Devyani" ,gender="FeMale"},
            new Student{studentId=105, name="Prachi" ,gender="FeMale"},


            };
            return View(student);
        }

        public IActionResult About()
        {
            List<Student> student = new List<Student>() {

            new Student{studentId=101, name="Pranay" ,gender="Male"},
            new Student{studentId=102, name="Sakshi" ,gender="FeMale"},
            new Student{studentId=103, name="Samarth" ,gender="Male"},
            new Student{studentId=104, name="Devyani" ,gender="FeMale"},
            new Student{studentId=105, name="Prachi" ,gender="FeMale"},


            };
            return View(student);
        }

        public IActionResult Contact()
        {
            List<Student> student = new List<Student>() {

            new Student{studentId=101, name="Pranay" ,gender="Male"},
            new Student{studentId=102, name="Sakshi" ,gender="FeMale"},
            new Student{studentId=103, name="Samarth" ,gender="Male"},
            new Student{studentId=104, name="Devyani" ,gender="FeMale"},
            new Student{studentId=105, name="Prachi" ,gender="FeMale"},


            };
            return View(student);
        }
    }
}
