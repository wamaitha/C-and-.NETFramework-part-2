using System;

namespace Operators_Assignments
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

       
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return false;
            }
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

       
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Employee emp = (Employee)obj;
            return Id == emp.Id;
        }

        
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

           
            if (emp1 == emp2)
            {
                Console.WriteLine("The two employees are equal.");
            }
            else
            {
                Console.WriteLine("The two employees are not equal.");
            }
        }
    }
}
