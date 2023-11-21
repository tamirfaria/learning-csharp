using Microsoft.VisualBasic;

namespace MyApp
{
  public static class Astrology
  {
    private enum ZodiacSign
    {
      Aries,
      Touro,
      Gemeos,
      Cancer,
      Leao,
      Virgem,
      Libra,
      Escorpiao,
      Ofiuco,
      Sagitario,
      Capricornio,
      Aquario,
      Peixes
    };
    public static void Start()
    {

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      Console.WriteLine("Olá! Que tal descobrir seu signo?");
      Console.WriteLine("");
      Thread.Sleep(1000);
      Console.WriteLine("Vamos começar conhecendo seu nome!");
      Console.WriteLine("");
      Thread.Sleep(1000);
      Console.WriteLine("Como podemos te chamar?");
      Console.WriteLine("");
      string name = Console.ReadLine()!;

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      Console.WriteLine($"{name}, primeiro me fale o ANO de seu nascimento: ");
      Console.WriteLine("");
      int year = int.Parse(Console.ReadLine()!);

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      Console.WriteLine($"{name}, digite por favor o MÊS de seu nascimento: ");
      Console.WriteLine("");
      int month = int.Parse(Console.ReadLine()!);

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      Console.WriteLine($"{name}, agora digite o DIA de seu nascimento: ");
      Console.WriteLine("");
      int day = int.Parse(Console.ReadLine()!);

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      Console.WriteLine("Só um momento... estamos verificando seu mapa astral");
      Console.WriteLine("");
      Thread.Sleep(3000);

      Console.Clear();
      Console.WriteLine("• Horóscopo •");
      Console.WriteLine("");
      DateTime birthday = new(1900, month, day);
      ZodiacSign sign = GetZodiacSign(birthday);
      var birthdayDateFull = string.Format("{0:dd/MM/yyyy}", new DateTime(year, month, day));
      Console.WriteLine($"Nome: {name}");
      Console.WriteLine($"Nascimento: {birthdayDateFull}");
      Console.WriteLine($"Signo: {GetSignDescription(sign)}");
      Console.WriteLine("");
      Thread.Sleep(1000);
      Console.WriteLine("Para finalizar aperte CTRL + C.");
      Console.ReadKey();
    }

    private static ZodiacSign GetZodiacSign(DateTime birthday)
    {
      foreach (ZodiacSign sign in Enum.GetValues(typeof(ZodiacSign)))
      {
        DateTime[] signDates = GetSignDates(sign);
        if (birthday >= signDates[0] && birthday <= signDates[1])
        {
          return sign;
        }
      }
      return ZodiacSign.Peixes;
    }

    private static DateTime[] GetSignDates(ZodiacSign sign)
    {
      return sign switch
      {
        ZodiacSign.Aries => new DateTime[] { new(1900, 4, 21), new(1900, 5, 13) },
        ZodiacSign.Touro => new DateTime[] { new(1900, 5, 14), new(1900, 6, 24) },
        ZodiacSign.Gemeos => new DateTime[] { new(1900, 6, 25), new(1900, 7, 20) },
        ZodiacSign.Cancer => new DateTime[] { new(1900, 7, 21), new(1900, 8, 19) },
        ZodiacSign.Leao => new DateTime[] { new(1900, 8, 20), new(1900, 9, 14) },
        ZodiacSign.Virgem => new DateTime[] { new(1900, 9, 15), new(1900, 10, 31) },
        ZodiacSign.Libra => new DateTime[] { new(1900, 11, 1), new(1900, 11, 21) },
        ZodiacSign.Escorpiao => new DateTime[] { new(1900, 11, 22), new(1900, 11, 29) },
        ZodiacSign.Ofiuco => new DateTime[] { new(1900, 11, 30), new(1900, 12, 17) },
        ZodiacSign.Sagitario => new DateTime[] { new(1900, 12, 18), new(1900, 1, 19) },
        ZodiacSign.Capricornio => new DateTime[] { new(1900, 1, 20), new(1900, 2, 15) },
        ZodiacSign.Aquario => new DateTime[] { new(1900, 2, 16), new(1900, 3, 11) },
        ZodiacSign.Peixes => new DateTime[] { new(1900, 3, 12), new(1900, 4, 20) },
        _ => throw new ArgumentOutOfRangeException(nameof(sign), sign, null),
      };
    }

    private static string GetSignDescription(ZodiacSign sign)
    {

      return sign switch
      {
        ZodiacSign.Aries => "♈ - Áries",
        ZodiacSign.Touro => "♉ - Touro",
        ZodiacSign.Gemeos => "♊ - Gêmeos",
        ZodiacSign.Cancer => "♋ - Câncer",
        ZodiacSign.Leao => "♌ - Leão",
        ZodiacSign.Virgem => "♍ - Virgem",
        ZodiacSign.Libra => "♎ - Libra",
        ZodiacSign.Escorpiao => "♏ - Escorpião",
        ZodiacSign.Ofiuco => "⛎ - Ofiúco",
        ZodiacSign.Sagitario => "♐ - Sagitário",
        ZodiacSign.Capricornio => "♑ - Capricórnio",
        ZodiacSign.Aquario => "♒ - Aquário",
        ZodiacSign.Peixes => "♓ - Peixes",
        _ => throw new ArgumentOutOfRangeException(nameof(sign), sign, null),
      };
    }
  }
}