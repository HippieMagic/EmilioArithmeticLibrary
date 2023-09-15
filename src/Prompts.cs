/// <summary>
/// Used for differnt display prompt scenarios
/// </summary>
namespace ArithmeticLibrary
{
    public class Prompts
    {
        public string Description = "\nWelcome to the Simple Calculator!\n" 
        + "This calculator can perform basic arithmetic operations.\n\n" 
        + "For addition please enter (+).\n" 
        + "For subtraction please enter (-).\n" 
        + "For division please enter (/).\n" 
        + "For multiplication please enter (*).\n"
        + "To quit enter (q).";
        public string FirstNumber = "Enter your first number: ";
        public string SecondNumber = "Enter your second number: ";
        public string ErrorInvalidOperator = "Please enter a valid operator!";
        public string NotAValidNumber = "\nNot a valid number!";
    }
}