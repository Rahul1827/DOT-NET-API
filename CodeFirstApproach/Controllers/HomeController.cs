using System.Diagnostics;
using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        public HomeController(StudentDBContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
             var stdData = await context.Students.ToListAsync();
            return View(stdData);
        }


        //Create 
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await context.Students.AddAsync(std);
                await context.SaveChangesAsync();
                TempData["Insert_Success"] = "Data has been inserted successfully !";
                return RedirectToAction("Index");
            }
            return View(std);
        }


        //Details

        public async Task<IActionResult> Details(int? id)
            
        {
            if (id== null ||context.Students==null)
            {
                return NotFound();
            }
            var stdData = await context.Students.FirstOrDefaultAsync(x=>x.studentId==id);


            if (stdData == null )
            {
                return NotFound();
            }

            return View(stdData);
        }


        //Edit

        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null || context.Students == null)
            {
                return NotFound();
            }
            var stdData = await context.Students.FindAsync(id);

            if (stdData == null)
            {
                return NotFound();
            }

            return View(stdData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Student std)
        {

            if (id != std.studentId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                context.Update(std);
                await context.SaveChangesAsync();
                TempData["Update_Success"] = "Data has been updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(std);
        }

        //Delete

        public async Task<IActionResult> Delete(int? id)
        {


            if (id == null || context.Students == null)
            {
                return NotFound();
            }
            var stdData = await context.Students.FirstOrDefaultAsync(x => x.studentId == id);


            if (stdData == null)
            {
                return NotFound();
            }


            return View(stdData);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var stdData = await context.Students.FindAsync(id);
            if (stdData != null)
            {


                context.Students.Remove(stdData);

            }
            await context.SaveChangesAsync();
            TempData["Delete_Success"] = "Data has been deleted Successfully !";
            return RedirectToAction("Index");

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
