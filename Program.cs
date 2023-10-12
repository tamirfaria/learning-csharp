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
        Console.WriteLine(
$@"Operador incorreto.
Gentileza tentar novamente.
{restartText}"
        );
        RestartApplication();
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
          Console.WriteLine(
$@"A soma dos valores é {sum}.
{restartText}"); RestartApplication(); break;

        case "-":
          Console.WriteLine(
$@"A subtração dos valores é {sub}.
{restartText}"); RestartApplication(); break;

        case "*":
          Console.WriteLine(
$@"A multiplicação dos valores é {mul}.
{restartText}"); RestartApplication(); break;

        case "/":
          Console.WriteLine(
$@"A divisão dos valores é {div}.
{restartText}"); RestartApplication(); break;

        case "%":
          Console.WriteLine(
$@"O resto da divisão dos valores é {res}.
{restartText}"); RestartApplication(); break;

        default:
          Console.WriteLine(
$@"Operador incorreto.
Gentileza tentar novamente.
{restartText}"); RestartApplication(); break;
      }
    }

    static void RestartApplication()
    {
      Console.ReadKey();
      Calculator();
    }
  }
}