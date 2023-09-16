/// <summary>
/// Interface for arithmetic operations to ensure consistency, flexibility, and ease of testing.
/// </summary>
namespace ArithmeticLibrary
{
    public interface IArithmeticOperations
    {
        float Add (float num1, float num2);
        float Subtract (float num1, float num2);
        float Divide (float num1, float num2);
        float Multiply (float num1, float num2);
        bool IsValidOperator (string input);
        bool IsValidNumber (string input);
    }
}