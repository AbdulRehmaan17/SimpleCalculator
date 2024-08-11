using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to the simple calculator");

            Console.WriteLine("Enter the value of x");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the vcalue of y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation");
            string Operation=Console.ReadLine();
            double result = 0;
            bool validOperation = true;
            switch (Operation)
            {
                case "+":
                    result = Add(x, y);
                    break;
                case "-":
                    result = Subtract(x, y);
                    break;
                case "*":
                    result = Multiply(x, y);
                    break;
                case "/":
                    result = Divide(x, y);
                    break;
            }
            Console.WriteLine("Your Answer is:" + result);        
    }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Divison not possible");
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}

