using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Requests;
using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Responses;
using Sample_CRUD_Operations_on_Student_and_Courses.Models;
using Sample_CRUD_Operations_on_Student_and_Courses.Repositories;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Services
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<StudentResponse> GetAll()
        {
            List<StudentResponse> students = new List<StudentResponse>();
            foreach (var student in _studentRepository.GetAll())
            {
                students.Add(new StudentResponse(student));
            }
            return students;
        }
        
        public StudentResponse GetByStudentId(int id)
        {
            return new StudentResponse(_studentRepository.GetByStudentId(id));
        }

        public StudentResponse Add(StudentRequest student)
        {
            return new StudentResponse(_studentRepository.Add(student));
        }

        public StudentResponse Update(int id, StudentRequest student)
        {
            return new StudentResponse(_studentRepository.Update(id, student));
        }

        public bool DeleteByStudentId(int id)
        {
            return _studentRepository.DeleteByStudentId(id);
        }
        
    }

}