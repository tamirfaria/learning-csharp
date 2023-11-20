namespace MyApp
{

  public static class Stopwatch
  {
    public static void Start()
    {
      Console.Clear();
      Console.WriteLine("• Cronômetro •");
      Console.WriteLine("");
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
        Start();
      }
    }
  }
}