using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Requests;
using Sample_CRUD_Operations_on_Student_and_Courses.Models;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetAll();
        public Student GetByStudentId(int id);
        public Student Add(StudentRequest student);
        public Student Update(int id, StudentRequest student);
        public bool DeleteByStudentId(int id);

    }

}
