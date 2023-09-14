/// <summary>
/// Performs basic arithmetic operations.
/// </summary>
namespace ArithmeticLibrary
{
    public class ArithmeticOperations : IArithmeticOperations
    {
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
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
        }

        public float Multiply (float num1, float num2)
        {
            return num1 * num2;
        }
    }
}