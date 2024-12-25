using ModelExample.Models;

namespace ModelExample.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.rollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {

            return new List<StudentModel>
            {
                new StudentModel { rollNo = 1, name = "Akshay", gender = "Male", Standard = 12 },
                new StudentModel { rollNo = 2, name = "Rahul", gender = "Male", Standard = 12 },
                new StudentModel { rollNo = 3, name = "Pranay", gender = "Male", Standard = 10 },
                new StudentModel { rollNo = 4, name = "Pushpa", gender = "FeMale", Standard = 12 },
                new StudentModel { rollNo = 5, name = "Ashwin", gender = "Male", Standard = 10 }


            };
        }
    }
}
