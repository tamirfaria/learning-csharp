using System.Globalization;

namespace MyApp
{
  public static class Date
  {
    public static void Start()
    {
      var date = DateTime.Now.ToString(new CultureInfo("pt-BR"));

      Console.Clear();
      Console.WriteLine("• Data •");
      Console.WriteLine("");
      Console.WriteLine("📆 Horário Oficial de Brasilia 📆");
      Console.WriteLine("");
      Console.WriteLine($"• • • {date} • • •");
      Console.WriteLine("");
      Thread.Sleep(1000);
      Console.WriteLine("Para finalizar aperte CTRL + C.");
      Console.ReadKey();

    }
  }
}