namespace MyApp
{
  public static class Menu
  {
    public static void Start()
    {
      Console.Clear();
      Console.WriteLine("• Menu •");
      Console.WriteLine("");
      Console.WriteLine("Escolha a opção desejada:");
      Console.WriteLine("");
      Console.WriteLine("1 - 🧮 Calculadora");
      Console.WriteLine("2 - ⏳ Cronômetro");
      Console.WriteLine("3 - 📖 Editor de Texto");
      Console.WriteLine("4 - 📆 Visualizador de Data");
      Console.WriteLine("5 - ❌ Sair");
      Console.WriteLine("");

      int menuOptionChange = int.Parse(Console.ReadLine()!);
      bool isValidInput =
        menuOptionChange == 1 ||
        menuOptionChange == 2 ||
        menuOptionChange == 3 ||
        menuOptionChange == 4;

      switch (menuOptionChange)
      {
        case 1: Calculator.Start(); break;
        case 2: Stopwatch.Start(); break;
        case 3: TextEditor.Start(); break;
        case 4: Date.Start(); break;
        case 5: Environment.Exit(0); break;
        default:
          Console.WriteLine("Entrada inválida");
          Thread.Sleep(1000);
          Start();
          break;
      }

      if (!isValidInput)
      {
        Console.Clear();
        Console.WriteLine("Entrada inválida");
        Thread.Sleep(1000);
        Start();
      }
    }
  }
}