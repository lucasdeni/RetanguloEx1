using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo L = new Retangulo();

            Console.WriteLine("Entre com a Largura e Altura do Retângulo: ");
            L.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            L.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
    }
}
