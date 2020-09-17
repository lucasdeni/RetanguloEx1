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
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = L.Perimetro(largura, altura);
            double a = L.Area(largura, altura);
            double d = L.Diagonal(largura, altura);

            Console.WriteLine("Área = " + a.ToString("F2" ,CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + p.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + d.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
