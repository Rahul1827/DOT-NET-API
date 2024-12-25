using APICrudConsume.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace APICrudConsume.Controllers
{
    public class StudentController : Controller
    {

        private string url = "https://localhost:44376/api/StudentAPI/";
        private HttpClient client = new HttpClient();


        //Get
        [HttpGet]
        public IActionResult Index()
        {

            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Student>>(result);

                if (data != null)
                {
                    students = data;

                }
            }
            return View(students);
        }

        //Post
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student std)
        {
            string data= JsonConvert.SerializeObject(std);
            StringContent stringContent = new StringContent(data , Encoding.UTF8 , "application/json");
            HttpResponseMessage response = client.PostAsync(url, stringContent).Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["Insert_message"] = "Studednt has been added successfully";
              return RedirectToAction("Index");
            }

            return View();
        }

        //Edit
        [HttpGet]
        public IActionResult Edit( int id)
        {

            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;


            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);

                if (data != null)
                {
                    std = data;

                }
            }
            return View(std);
        }


        [HttpPost]
        public IActionResult Edit(Student std)
        {
            string data = JsonConvert.SerializeObject(std);
            StringContent stringContent = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(url +std.studentId, stringContent).Result;

            if (response.IsSuccessStatusCode)
            {
                TempData["Update_message"] = "Studednt data has been updated successfully";
                return RedirectToAction("Index");
            }

            return View();
        }


        //Details

        [HttpGet]
        public IActionResult Details(int id)
        {

            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;


            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);

                if (data != null)
                {
                    std = data;

                }
            }
            return View(std);
        }



        //Delete

        [HttpGet]
        public IActionResult Delete(int id)
        {

            Student std = new Student();
            HttpResponseMessage response = client.GetAsync(url + id).Result;


            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<Student>(result);

                if (data != null)
                {
                    std = data;

                }
            }
            return View(std);
        }




        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            
            HttpResponseMessage response = client.GetAsync(url + id).Result;


            if (response.IsSuccessStatusCode)
            {
                TempData["Delete_message"] = "Studednt data has been deleted successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}





