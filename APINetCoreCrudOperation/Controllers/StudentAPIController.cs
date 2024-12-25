using APINetCoreCrudOperation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APINetCoreCrudOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly CfnewContext context;

        public StudentAPIController(CfnewContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        { 
          var data =await context.Students.ToListAsync();
            return Ok(data);
        }
        //Get By ID
        [HttpGet ("{id}")]
        public async Task<ActionResult<List<Student>>> GetStudentById(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {

                return NotFound();
            }
            return Ok(student);
        }

        //Post
        [HttpPost]
        public async Task<ActionResult<List<Student>>> CreateStudent(Student std)
        {
             await context.Students.AddAsync(std);
            await context.SaveChangesAsync();
            return Ok(std);
           
        }

        //Put
        [HttpPut ("{id}")]
        public async Task<ActionResult<List<Student>>> UpdateStudent(int id , Student std)
        {
            if (id != std.StudentId)
            {
                return BadRequest();
            }
            context.Entry(std).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(std);
        }


        //Delete By ID
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> Delete(int id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {

                return NotFound();
            }
            context.Students.Remove(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }

    }
}
