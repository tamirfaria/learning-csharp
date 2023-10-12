namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Calculator();
    }

    static void Calculator()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor: ");
      float firstValue = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      Console.WriteLine("Digite o operador do calculo");
      string calOperator = Console.ReadLine();
      bool isValidOperator = OperatorValidation(calOperator);
      Console.WriteLine("");
      if (!isValidOperator)
        return;

      Console.WriteLine("Agora digite o segundo valor: ");
      float secondValue = float.Parse(Console.ReadLine());
      Console.WriteLine("");

      float sum = firstValue + secondValue;
      float sub = firstValue - secondValue;
      float mul = firstValue * secondValue;
      float div = firstValue / secondValue;
      float res = firstValue % secondValue;

      if (calOperator == "+")
        Console.WriteLine($"A soma dos valores é {sum}.");

      if (calOperator == "-")
        Console.WriteLine($"A subtração dos valores é {sub}.");

      if (calOperator == "*")
        Console.WriteLine($"A multiplicação dos valores é {mul}");

      if (calOperator == "/")
        Console.WriteLine($"A divisão dos valores é {div}.");

      if (calOperator == "%")
        Console.WriteLine($"O resto da divisão dos valores é {res}.");
    }

    static bool OperatorValidation(string calOperator)
    {
      bool isValidOperator = calOperator == "+" || calOperator == "-" || calOperator == "*" || calOperator == "/" || calOperator == "%";

      if (!isValidOperator)
      {
        Console.WriteLine("Operador incorreto.");
        Console.WriteLine("Gentileza tentar novamente.");
        return false;
      }
      return true;
    }
  }
}