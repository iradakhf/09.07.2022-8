using System;
namespace ConsoleApp16
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Your task is to create a function that does four basic mathematical operations.

            //The function should take three arguments -operation(string / char), value1(number), value2(number).
            //The function should return result of numbers after applying the chosen operation.
            int num = performTheGivenOperation(4, 5, '+');
            Console.WriteLine(num);
            
        }
        
        public static int performTheGivenOperation(int number1, int number2, char i)
        {
            int operation=0;

            switch (i)
            {
                case '+':
                    operation =number1 + number2;
                    break;
                case '-':
                    operation = number1 - number2;
                    break;
                case '*':
                    operation = number1 * number2;
                    break;
                case '/':
                    operation = number1 / number2;
                    break;
            }
            return operation;
        }
    }
}

