using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            double result = 0;

            Console.Write("Please enter a number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter another number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter + to add the numbers ");
            Console.Write("Please enter - to subtract the numbers ");
            Console.Write("Please enter * to multiply the numbers ");
            Console.Write("Please enter / to divide the numbers");
            string expression = Console.ReadLine();
            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 
            switch(expression)
            {
                case "+":
                    result = Add(number1, number2);
                    break;
                case "-":
                    result = Subtract(number1, number2);
                    break;
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "/":
                    result = Divide(number1, number2);
                    break;


            }
             
            
                // Use methods for each type of calculation.

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }


        public static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public static double Subtract(double num1, double num2)
        {   double result = num1 - num2;
            return result;
        }
        public static double Multiply(double num1, double num2)
        {   double result = num1 * num2;
            return result;
        }
        public static double Divide(double num1, double num2)
        {  double result = num1 / num2;
            return result;
        }
    }
}
