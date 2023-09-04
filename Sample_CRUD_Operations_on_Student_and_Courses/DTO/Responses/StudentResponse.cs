using Sample_CRUD_Operations_on_Student_and_Courses.Enumerations;
using Sample_CRUD_Operations_on_Student_and_Courses.Models;

namespace Sample_CRUD_Operations_on_Student_and_Courses.DTO.Responses
{
    public class StudentResponse
    {
        public int Id { get; set; } 
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }

        public StudentResponse(Student student) 
        {
            Id = student.Id;
            StudentId = student.StudentId;
            FirstName = student.FirstName;
            LastName = student.LastName;
            Mail = student.Mail;
            Phone = student.Phone;
            Gender = student.Gender;
            Address = student.Address;
        }

    }

}