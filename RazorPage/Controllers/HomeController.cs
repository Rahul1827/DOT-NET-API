using Microsoft.AspNetCore.Mvc;

namespace RazorPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            ViewBag.data1 = "Hello Rahul";
            ViewBag.data2 = 25;
            ViewBag.data3 = DateTime.Now.ToLongDateString();

            string[] arr = { "Rahul", "Bhoutik", "Lavesh" };

            ViewBag.data4 = arr;

          ViewBag.data5= new List<string>()
          {
            "Rahul", "Bhoutik", "Lavesh"

          };

            ViewData["data6"] = "Welcome Rahul";

            //ViewData["Data1"] = "Rahul";
            //ViewData["Data2"] = 25;
            //ViewData["Data3"] = DateTime.Now.ToLongDateString();


            //string[] arr = { "Rahul", "Akshay", "Pranay" };

            //ViewData["Data4"] = arr;

            //ViewData["Data5"] = new List<string>()
            //{ 
            //        "Cricket" , "Football" , "Hockey"
            
            //};


            return View();
        }


        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }
    }
}
