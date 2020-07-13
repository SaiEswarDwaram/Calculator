using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int operation;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Select the number the perform the specified operation. \n 1.Addition \n 2.Subtraction \n 3.Multiplication \n 4.Division");
            operation = Convert.ToInt16(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else
                        Console.WriteLine("The denominator cannot be a zero");
                    break;

            }

        }
    }
}
