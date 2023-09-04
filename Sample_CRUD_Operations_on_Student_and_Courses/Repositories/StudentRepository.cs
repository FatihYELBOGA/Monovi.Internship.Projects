using Microsoft.EntityFrameworkCore;
using Sample_CRUD_Operations_on_Student_and_Courses.Configurations;
using Sample_CRUD_Operations_on_Student_and_Courses.DTO.Requests;
using Sample_CRUD_Operations_on_Student_and_Courses.Models;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private readonly Database _database;

        public StudentRepository(Database database)
        {
            _database = database;
        }

        public List<Student> GetAll()
        {
            return _database.Students.ToList();
        }
        
        public Student GetByStudentId(int id)
        {
            return _database.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        public Student Add(StudentRequest student)
        {
            Student addedStudent = new Student()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Mail = student.Mail,
                Phone = student.Phone,
                Gender = student.Gender,
                Address = student.Address
            };

            Student returnedStudent = _database.Students.Add(addedStudent).Entity;
            _database.SaveChanges();

            return returnedStudent;
        }

        public Student Update(int id, StudentRequest student)
        {
            Student updatedStudent = this.GetByStudentId(id);
            updatedStudent.StudentId = student.StudentId;
            updatedStudent.FirstName = student.FirstName;
            updatedStudent.LastName = student.LastName;
            updatedStudent.Mail = student.Mail;
            updatedStudent.Phone = student.Phone;
            updatedStudent.Gender = student.Gender;
            updatedStudent.Address = student.Address;

            Student returnedStudent = _database.Students.Update(updatedStudent).Entity;
            _database.SaveChanges();

            return returnedStudent;
        }

        public bool DeleteByStudentId(int id)
        {
            Student foundStudent = _database.Students.Where(s => s.Id == id).FirstOrDefault();
            if (foundStudent != null)
            {
                _database.Students.Remove(foundStudent);
                _database.SaveChanges();
                return true;
            }

            return false;
        }

    }

}
