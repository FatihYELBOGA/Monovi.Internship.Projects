using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Requests;
using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Responses;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Services
{
    public interface IStudentService
    {
        public List<StudentResponse> GetAll();
        public StudentResponse GetByStudentId(int id);
        public StudentResponse Add(StudentRequest student);
        public StudentResponse Update(int id, StudentRequest student);
        public bool DeleteByStudentId(int id);

    }

}
