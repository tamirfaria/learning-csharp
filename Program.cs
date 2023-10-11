namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Product mouse = new(1, "Mouse Gamer", 119.90);
      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
    }
  }

  struct Product
  {
    public Product(int id, string name, double price)
    {
      Id = id;
      Name = name;
      Price = price;
    }
    public int Id;
    public string Name;
    public double Price;
    public readonly double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }
}