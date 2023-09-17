/// <summary>
/// Main program, performs basic math
/// </summary>
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

            // loop until user quits
            while (continueCalculating)
            {
                // get user input, display error message until valid operator is entered
                var operationChoice = Console.ReadLine();
                var isValid = operations.IsValidOperator(operationChoice);

                if (!isValid)
                {
                    Console.WriteLine(prompts.ErrorInvalidOperator);
                    continue;
                }

                // if the user enters "q" exit the loop 
                if (operationChoice != "q")
                {
                    // make sure the first number is a valid number, else show error and prompt to try again
                    float num1 = operations.GetValidNumber(prompts.FirstNumber, operations);
                    if (num1 == -9999) continue;

                    // make sure the second number is a valid number, else show error and prompt to try again
                    float num2 = operations.GetValidNumber(prompts.SecondNumber, operations);
                    if (num2 == -9999) continue;

                    // based off of what operator the user entered do the calculation 
                    float result = operations.PerformOperation(operations, operationChoice, num1, num2);

                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine(prompts.EnterAnOperator);
                }
                else
                {
                    continueCalculating = false;
                }
            }
        }
    }
}
