using System;
using System.Data.Entity;

namespace Entity_Framework2
{
   
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }


    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student { Name = "John Doe" };
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student saved to the database.");
            }

            Console.ReadKey(); 
        }
    }
}

