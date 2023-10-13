namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("• Menu •");
      Console.WriteLine("Escolha a opção desejada:");
      Console.WriteLine("1 - 🧮 Calculadora");
      Console.WriteLine("2 - ⏳ Cronômetro");
      Console.WriteLine("3 - ❌ Sair");

      int menuOptionChange = int.Parse(Console.ReadLine()!);
      bool isValidInput =
        menuOptionChange == 1 ||
        menuOptionChange == 2 ||
        menuOptionChange == 3;

      switch (menuOptionChange)
      {
        case 1: Calculator(); break;
        case 2: Stopwatch(); break;
        case 3: Environment.Exit(0); break;
        default:
          Console.WriteLine("Entrada inválida");
          Thread.Sleep(1000);
          Menu();
          break;
      }

      if (!isValidInput)
      {
        Console.Clear();
        Console.WriteLine("Entrada inválida");
        Thread.Sleep(1000);
        Menu();
      }
    }

    static void Calculator()
    {
      Console.Clear();
      Console.WriteLine("• Calculadora •");
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
      Calculator();
    }

    static void Stopwatch()
    {
      Console.Clear();
      Console.WriteLine("• Cronômetro •");
      Console.WriteLine("Digite o tempo do cronômetro em segundos:");
      int seconds = int.Parse(Console.ReadLine()!);
      Console.WriteLine("");

      StartStopwatch(seconds);
    }

    static void StartStopwatch(int time)
    {
      int currentTime = 0;

      while (time != currentTime)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine($"⏳ : {currentTime}");
        Thread.Sleep(1000);
      }

      if (time == currentTime)
      {
        Console.Clear();
        Console.WriteLine("⏳ : Cronômetro finalizado.");
        Console.WriteLine("Para reiniciar aperte ENTER ou CTRL + C para finalizar."); Console.ReadKey();
        Stopwatch();
      }
    }
  }
}