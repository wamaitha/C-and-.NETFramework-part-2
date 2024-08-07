using System;

namespace polymorphism_assignment
{
  
    public interface IQuitable
    {
        void Quit();
    }

    
    public class Employee : IQuitable
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        
        public void Quit()
        {
            Console.WriteLine($"{Name} has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IQuitable employee = new Employee("John Doe");
            employee.Quit();

            Console.ReadLine();
        }
    }
}
