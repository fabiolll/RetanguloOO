using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProblemaRetangulo
{
    public class Retangulo
    {
        public double largura;
        public double altura;
        public double CalcularArea()
        {
            double area = altura * largura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * (largura) + 2 * (altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            double diagonal = Math.Sqrt((altura * altura) + (largura * largura));
            return diagonal;
        }


    }
}