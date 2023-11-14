/// <summary>
/// Main program, performs basic math
/// </summary>
namespace ArithmeticLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = new ArithmeticOperations();
            var random = new Random();
            var score = 0;
            const int totalQuestions = 5; // Number of questions in the quiz

            Console.WriteLine("Welcome to the Arithmetic Quiz Game!");
            Console.WriteLine("You will be given " + totalQuestions + " questions.");

            for (var i = 0; i < totalQuestions; i++)
            {
                // Generate random numbers and select an operation
                float num1 = random.Next(1, 10);
                float num2 = random.Next(1, 10);
                string[] operationChoices = { ArithmeticOperations.Addition, ArithmeticOperations.Subtraction, ArithmeticOperations.Multiplication, ArithmeticOperations.Division };
                var operation = operationChoices[random.Next(operationChoices.Length)];

                // Calculate correct answer
                var correctAnswer = operations.PerformOperation(operations, operation, num1, num2);

                // Ask question
                Console.WriteLine($"Question {i + 1}: What is {num1} {operation} {num2}?");
                var userAnswer = Console.ReadLine();

                // Check answer
                if (float.TryParse(userAnswer, out var userResponse) && userResponse == correctAnswer)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer is {correctAnswer}.");
                }
            }

            // End of game
            Console.WriteLine($"Quiz over! Your score: {score}/{totalQuestions}");
        }
    }
}