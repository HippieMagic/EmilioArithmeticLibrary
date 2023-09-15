using System;

namespace ArithmeticLibrary
{
    class Program
    {
        public const string Addition = "+";
        public const string Subtraction = "-";
        public const string Division = "/";
        public const string Multiplication = "*";

        static void Main(string[] args)
        {
            ArithmeticOperations operations = new();
            Prompts prompts = new();
            bool continueCalculating = true;

            Console.WriteLine(prompts.Description);

            while (continueCalculating)
            {
                var operationChoice = Console.ReadLine();
                var isValid = operations.IsValidOperator(operationChoice);

                if (!isValid)
                {
                    Console.WriteLine(prompts.ErrorInvalidOperator);
                    continue;
                }

                if (operationChoice == "q")
                {
                    continueCalculating = false;
                    break;
                }

                float num1 = operations.GetValidNumber(prompts.FirstNumber, operations);
                if (num1 == -9999) continue;

                float num2 = operations.GetValidNumber(prompts.SecondNumber, operations);
                if (num2 == -9999) continue;

                float result = operations.PerformOperation(operations, operationChoice, num1, num2);

                Console.WriteLine($"Result: {result}");
                Console.WriteLine("\nEnter an operator (+,-,/,*) to continue or (q) to quit.");
            }
        }
    }
}
