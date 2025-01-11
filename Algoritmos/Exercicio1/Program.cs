using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


/* 
Fazer um programa para ler o código de uma peça 1, o número de peças 1,
o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 
e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago. */

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short codigoPeca = 0;
            sbyte quantidadePeca = 0;
            float valorPeca = 0;
            float valorTotal = 0;

            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Informe o codigo da peça: ");
                codigoPeca = short.Parse(Console.ReadLine());
                Console.Write("Informe a quantidade de peças: ");
                quantidadePeca = sbyte.Parse(Console.ReadLine());
                Console.Write("Informe o valor da peça:R$ ");
                valorPeca = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                valorTotal += valorPeca * quantidadePeca;

            }


            Console.WriteLine("Valor total da compra: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
