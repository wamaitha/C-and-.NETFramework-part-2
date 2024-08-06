using System;

namespace MathOperations
{
    
    public class MathOps
    {
        
        public void PerformOperation(int num1, int num2)
        {
           
            int result = num1 * num1;

            Console.WriteLine("The second integer is: " + num2);
            Console.WriteLine("The result of the math operation on the first integer is: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            MathOps mathOps = new MathOps();

          
            mathOps.PerformOperation(5, 10);

           
            mathOps.PerformOperation(num1: 7, num2: 14);

            
            Console.ReadLine();
        }
    }
}
