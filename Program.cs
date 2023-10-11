namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Product mouse = new(1, "Mouse Gamer", 119.90, EProductType.Product);
      Product eletricService = new(2, "Eletric Services", 220.90, EProductType.Service);

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine(mouse.ProductType);

      Console.WriteLine(eletricService.Id);
      Console.WriteLine(eletricService.Name);
      Console.WriteLine(eletricService.Price);
      Console.WriteLine(eletricService.ProductType);
    }
  }

  struct Product
  {
    public Product(int id, string name, double price, EProductType productType)
    {
      Id = id;
      Name = name;
      Price = price;
      ProductType = productType;
    }
    public int Id;
    public string Name;
    public double Price;

    public EProductType ProductType;
    public readonly double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }

  enum EProductType
  {
    Product = 1,
    Service = 2
  }
}