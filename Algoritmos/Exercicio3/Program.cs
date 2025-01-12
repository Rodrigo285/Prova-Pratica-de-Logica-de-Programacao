using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
Com base na tabela de preços ao lado, faça 
um programa que leia o código de um item e a 
quantidade deste item. A seguir, calcule e 
mostre o valor da conta a pagar.*/

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 38));
            Console.WriteLine("CODIGO      ESPECIFICAÇÃO      PREÇO");
            Console.WriteLine(new string('-', 38));
            Console.WriteLine("  1        Cachorro Quente    R$ 4.00");
            Console.WriteLine("  2        X - Salada         R$ 4.50");
            Console.WriteLine("  3        X - Bacon          R$ 5.00");
            Console.WriteLine("  4        Torrada simples    R$ 2.00");
            Console.WriteLine("  5        Refrigerante       R$ 4.00");
            Console.WriteLine(new string('-', 38));

            // -------------variaveis global-------------
            byte codigo = 0;
            short quantidade = 0;
            double valor = 0;

            Console.Write("Informe o codigo do produto:");
            codigo = byte.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a quantidade do produto: ");
            quantidade = short.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //--------------estrutura de decisão-----------

            if (codigo == 1)
            {
                valor = 4.00 * quantidade;
                Console.WriteLine($"Pedido: {quantidade} Cachorro Quente");
                Console.WriteLine($"Valor total R$ {valor.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            if (codigo == 2) 
            {
                valor = 4.50 * quantidade;
                Console.WriteLine($"Pedido: {quantidade} X - Salada");
                Console.WriteLine($"Valor total R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigo == 3)
            {
                valor = 5.00 * quantidade;
                Console.WriteLine($"Pedido: {quantidade} X - Bacon");
                Console.WriteLine($"Valor total R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigo == 4)
            {
                valor = 2.00 * quantidade;
                Console.WriteLine($"Pedido: {quantidade} Torrada Simples");
                Console.WriteLine($"Valor total R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            if (codigo == 5)
            {
                valor = 4.00 * quantidade;
                Console.WriteLine($"Pedido: {quantidade} Refrigerante");
                Console.WriteLine($"Valor total R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
            }




        }
    }
}
        


   
