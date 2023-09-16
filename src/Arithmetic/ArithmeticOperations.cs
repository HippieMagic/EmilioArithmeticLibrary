/// <summary>
/// Performs basic arithmetic operations
/// </summary>
namespace ArithmeticLibrary
{
    public class ArithmeticOperations : IArithmeticOperations
    {
        public const string Addition = "+";
        public const string Subtraction = "-";
        public const string Division = "/";
        public const string Multiplication = "*";
        public float Add (float num1, float num2)
        {
            return num1 + num2;
        }

        public float Subtract (float num1, float num2)
        {
            return num1 - num2;
        }

        public float Divide (float num1, float num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                return -9999;
            }
        }

        public float Multiply (float num1, float num2)
        {
            return num1 * num2;
        }
        
        // only return true if it is a valid operator
        public bool IsValidOperator (string input)
        {
            input = input.Trim().ToLower(); // Convert to lowercase and trim whitespace
            return input == "+" || input == "-" || input == "*" || input == "/" || input == "q";
        }

        // only return true if it is a valid number
        public bool IsValidNumber (string input)
        {
            if(float.TryParse(input, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public float GetValidNumber(string prompt, ArithmeticOperations operations)
        {
            Prompts prompts = new();
            float number = -9999;

            while (true)
            {
                Console.WriteLine(prompt); // Display the specified prompt to the user
                var input = Console.ReadLine();
                var isValid = operations.IsValidNumber(input);

                if (!isValid)
                {
                    Console.WriteLine(prompts.NotAValidNumber); // Notify the user of an invalid input
                    continue;
                }

                number = (float)Convert.ToDouble(input);
                if (number == 0)
                {
                    Console.WriteLine("\nDivision by zero is not allowed.");
                    continue;
                }

                return number;
            }
        }

        // Perform arithmetic operations based on the user's choice: 
        // addition (+), subtraction (-), division (/), or multiplication (*)
        public float PerformOperation(ArithmeticOperations operations, string operationChoice, float num1, float num2)
        {
            switch (operationChoice)
            {
                case Addition:
                    return operations.Add(num1, num2);
                case Subtraction:
                    return operations.Subtract(num1, num2);
                case Division:
                    return operations.Divide(num1, num2);
                case Multiplication:
                    return operations.Multiply(num1, num2);
                default:
                    return 0;
            }
        }
    }
}




