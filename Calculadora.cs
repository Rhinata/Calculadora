using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program.cs.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
          public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
          public void Multiplicar (int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
          public void Dividir (int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}"); //Para fazer o ° basta apenas clicar em shift e do lado do espaço alt gr
        }
        public void coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}"); // Math.Round Significa colocar quantas casas decimais irá querer trabalhar apos a virgula
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($" Raiz quadrada de {x} = {raiz}");
        }
    }
}
