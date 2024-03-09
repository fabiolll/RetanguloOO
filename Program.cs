using ProblemaRetangulo;

namespace RetanguloOriObj;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos calcular as propriedades do Retangulo!");
        Retangulo r = new Retangulo();
        Console.WriteLine("Informe a altura:");
        r.altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe a largura:");
        r.largura = double.Parse(Console.ReadLine());
        Console.WriteLine($"Largura:{r.largura}\nAltura: {r.altura}\nArea: {r.CalcularArea()}\nPerimetro: {r.CalcularPerimetro()}\nDiagonal: {r.CalcularDiagonal()}");

    }
}
