using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
 
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos. 
 
Fórmula area = pi * raio² 
 
Considere o valor de pi = 3.14159 
 
 */

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 0, area = 0;
            double pi = 3.14159;

            Console.Write("Informe valor raio: ");
            raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * (raio * raio);

            Console.WriteLine($"O valor da area do circulo é A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
