namespace MyApp
{
  public static class TextEditor
  {
    public static void Start()
    {
      Console.Clear();
      Console.WriteLine("• Editor de Texto •");
      Console.WriteLine("");
      Console.WriteLine("Digite a ação desejada: ");
      Console.WriteLine("");
      Console.WriteLine("1 - 📃 Abrir um arquivo");
      Console.WriteLine("2 - 📄 Criar um arquivo");
      Console.WriteLine("3 - ❌ Sair");

      short option = short.Parse(Console.ReadLine()!);
      string invalidText = "Opção inválida. Tente novamente.";
      bool isValidOption =
        option == 1 ||
        option == 2 ||
        option == 3;

      if (!isValidOption)
      {
        Console.WriteLine(invalidText);
        Thread.Sleep(1000);
        Start();
      }

      switch (option)
      {
        case 1: OpenFile(); break;
        case 2: EditFile(); break;
        case 3: Environment.Exit(0); break;
        default: break;
      }
    }
    static void OpenFile()
    {
      string[] archivesList = Directory.GetFiles("archives");
      Console.Clear();
      Console.WriteLine("📂 Digite o número do arquivo que vc deseja abrir:");
      Console.WriteLine("");
      for (var i = 0; i < archivesList.Length; i++)
      {
        Console.WriteLine($"📝 {i} - archives/archive-{i}.txt");
      }
      uint option = uint.Parse(Console.ReadLine()!);
      if (option > archivesList.Length - 1)
      {
        Console.WriteLine("❌ Comando inválido. Tente novamente");
        Thread.Sleep(1000);
        OpenFile();
      }

      string path = $"archives/archive-{option}.txt";
      using var file = new StreamReader(path);
      string text = file.ReadToEnd();

      Console.Clear();
      Console.WriteLine($"📄 - {path}");
      Console.WriteLine("");
      Console.WriteLine(text);
      Console.WriteLine("");
      Console.WriteLine("❌ Digite ENTER para sair");
      Console.ReadLine();
    }

    static void EditFile()
    {
      Console.Clear();
      Console.WriteLine("❌ Digite ESC para sair");
      Console.WriteLine("📄 Digite seu texto aqui abaixo");
      Console.WriteLine("");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while (Console.ReadKey().Key != ConsoleKey.Escape);

      SaveFile(text);
    }

    static void SaveFile(string text)
    {
      Console.Clear();
      int directoryLength = Directory.GetFiles("archives").Length;
      string path = $"archives/archive-{directoryLength}.txt";

      using var file = new StreamWriter(path);
      file.Write(text);

      Console.WriteLine("💾 Arquivo salvo com sucesso");
      Console.WriteLine("❌ Digite ENTER para sair");
      Console.ReadLine();
    }

  }
}