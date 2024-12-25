using ModelExample.Models;

namespace ModelExample.Repository
{
    public interface IStudent
    {
        List<StudentModel>getAllStudents();
        StudentModel getStudentById(int id);
    }
}
