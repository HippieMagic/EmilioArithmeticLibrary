/// <summary>
/// Main class
/// </summary>
namespace ArithmeticLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      Prompts prompts = new();
      Console.WriteLine(prompts.Description);
      
      bool continueCalculating = true;
      
      while (continueCalculating)
      {
        var operationChoice = Console.ReadLine();
        if (operationChoice != null && operationChoice != "x")
        {

        }
        else if (operationChoice == "x")
        {
          return;
        }
        else
        {
          
        }
      }

    }
  }
}