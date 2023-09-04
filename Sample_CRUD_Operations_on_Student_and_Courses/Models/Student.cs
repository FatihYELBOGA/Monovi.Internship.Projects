using Sample_CRUD_Operations_on_Student_and_Courses.Enumerations;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }

    }

}
