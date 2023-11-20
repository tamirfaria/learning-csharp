namespace MyApp
{
  public static class Calculator
  {
    public static void Start()
    {
      Console.Clear();
      Console.WriteLine("• Calculadora •");
      Console.WriteLine("");
      Console.WriteLine("Digite o primeiro valor: ");
      float firstValue = float.Parse(Console.ReadLine()!);
      Console.WriteLine("");

      string restartText = "Pressione enter para realizar outra operação ou 'CTRL + C' para finalizar.";

      Console.WriteLine("Digite o operador do cálculo");
      string? calOperator = Console.ReadLine();
      Console.WriteLine("");

      bool isValidOperator =
        calOperator == "+" ||
        calOperator == "-" ||
        calOperator == "*" ||
        calOperator == "/" ||
        calOperator == "%";

      if (!isValidOperator)
      {
        Console.WriteLine("Operador incorreto.");
        Console.WriteLine("Gentileza tentar novamente");
        Console.WriteLine($"{restartText}");
        RestartCalculatorApp();
      }

      Console.WriteLine("Agora digite o segundo valor: ");
      float secondValue = float.Parse(Console.ReadLine()!);
      Console.WriteLine("");

      float sum = firstValue + secondValue;
      float sub = firstValue - secondValue;
      float mul = firstValue * secondValue;
      float div = firstValue / secondValue;
      float res = firstValue % secondValue;

      switch (calOperator)
      {
        case "+":
          Console.WriteLine($"A soma dos valores é {sum}.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;

        case "-":
          Console.WriteLine($"A subtração dos valores é {sub}.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;

        case "*":
          Console.WriteLine($"A multiplicação dos valores é {mul}.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;

        case "/":
          Console.WriteLine($"A divisão dos valores é {div}.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;

        case "%":
          Console.WriteLine($"O resto da divisão dos valores é {res}.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;

        default:
          Console.WriteLine($"Operador incorreto.");
          Console.WriteLine($"Gentileza tentar novamente.");
          Console.WriteLine($"{restartText}");
          RestartCalculatorApp(); break;
      }
    }
    static void RestartCalculatorApp()
    {
      Console.ReadKey();
      Start();
    }
  }
}