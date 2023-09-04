using Microsoft.EntityFrameworkCore;
using Sample_CRUD_Operations_on_Student_and_Courses.Models;

namespace Sample_CRUD_Operations_on_Student_and_Courses.Configurations
{
    public class Database : DbContext
    {
        public Database(DbContextOptions options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public static void Seed(Database database)
        {
            if (database.Database.GetPendingMigrations().Count() == 0)
            {
                if (database.Students.Count() == 0)
                {
                    database.AddRange(students);
                    database.SaveChanges();
                }
            }
        }

        private static Student[] students =
        {
            new Student()
            {
                StudentId = "270201028",
                FirstName = "Fatih",
                LastName = "YELBOĞA",
                Mail = "fatihyelboga@gmail.com",
                Phone = "+90-541-861-57-50",
                Gender = Enumerations.Gender.MALE,
                Address = "Kargıcak Mahallesi (Atatürk Caddesi) No: 98/2, Alanya/Antalya"
            },
            new Student()
            {
                StudentId = "270201020",
                FirstName = "Osman",
                LastName = "ALTUNAY",
                Mail = "osmanaltunay@gmail.com",
                Phone = "+90-545-042-48-48",
                Gender = Enumerations.Gender.MALE,
                Address = "Keçiören Kalaba Mahallesi (Fatih Caddesi) No: 45/5, Keçiören/Ankara"
            },

        };

    }

}
