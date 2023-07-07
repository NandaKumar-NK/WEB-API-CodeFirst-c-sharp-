using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAPIwithEFCodeFirst.Data;

namespace WebAPIwithEFCodeFirst.Services.StudentService
{
    public class StudentService : IStudentService
    {
        public StudentDataContext _studentDataContext;
        public StudentService(StudentDataContext studentDataContext)
        {
            _studentDataContext = studentDataContext;
        }

        public async Task<List<Student>> GetAllStudentDetails()
        {
            var students = await _studentDataContext.Students.ToListAsync();
            return students;
        }

        public async Task<Student?> GetAllStudentDetailById(int id)
        {
            //var srudent = studentsList.Find(s=>s.StudID==id)
            var student = await _studentDataContext.Students.FindAsync(id);

            if (student is null)
            {
                return null;
            }
            return student;
        }
        
        public async Task<List<Student>> AddStudentDetail(Student stud)
        {
            _studentDataContext.Students.Add(stud);
            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }

        public async Task<List<Student>?> UpdateStudentDetailById(Student stud)
        {
            _studentDataContext.Entry(stud).State=EntityState.Modified;
            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }

        public async Task<List<Student>?> DeleteStudentDetailById(int id)
        {
            var student = await _studentDataContext.Students.FindAsync(id);
            if (student is null)
            {
                return null;
            }
            _studentDataContext.Remove(student);
            await _studentDataContext.SaveChangesAsync();
            return await _studentDataContext.Students.ToListAsync();
        }
    }
}
