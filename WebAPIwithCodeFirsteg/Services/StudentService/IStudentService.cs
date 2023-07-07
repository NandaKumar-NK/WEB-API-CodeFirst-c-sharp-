

namespace WebAPIwithEFCodeFirst.Services.StudentService
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentDetails();
        Task<Student?> GetAllStudentDetailById(int id);

        Task<List<Student>> AddStudentDetail(Student stud);

        Task<List<Student>?> UpdateStudentDetailById(Student stud);
        Task<List<Student>?> DeleteStudentDetailById(int id);


    }
}
