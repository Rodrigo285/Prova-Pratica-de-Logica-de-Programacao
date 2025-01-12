using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do 
segundo grau ( ax²+bx + c = 0) 
Em seguida, mostrar os valores das raízes da equação, conforme exemplos, 
usando a fórmula de Baskara (veja 
abaixo). Se a equação não possuir raízes (o valor de "a"
não pode ser zero, e o valor de "delta" não pode ser 
negativo), mostrar uma mensagem "Impossivel calcular".  
 */
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double delta = 0;

            Console.Write("Informe o valor de coificiente 'A':");
            A = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("Informe o valor de coificiente 'B':");
            B = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

            Console.Write("Informe o valor de coificiente 'C':");
            C = float.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);




            if (A == 0)
            {
                Console.WriteLine("Valor imposivel de calcular");

            }
            else
            {
                delta = (B * B) - (4 * A * C);



                if (delta < 0)
                {
                    Console.WriteLine("Valor impossivel de calcular");
                }
                else
                {
                    double raizDelta = Math.Sqrt(delta);
                    double x1 = (-B + raizDelta) / (2 * A);
                    double x2 = (-B - raizDelta) / (2 * A);

                    Console.WriteLine($"X1 {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"X2 {x2.ToString("F5", CultureInfo.InvariantCulture)}");
                }

            }
        }
    }
}
