using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex1
{
    class Retangulo
    {
        public double Area(double l, double a)
        {
            return l * a;
        } 
        public double Perimetro(double l, double a)
        {
            return (l * 2) + (a * 2);
        }
        public double Diagonal(double l, double a)
        {
            return Math.Sqrt((l * l) + (a * a));
        }
    }
}
