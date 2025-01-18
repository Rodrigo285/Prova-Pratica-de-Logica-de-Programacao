using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*
   
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. 
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 
 
 */

namespace Exercicio6 {
    internal class Program {
        static void Main(string[] args) {

            byte N = byte.Parse(Console.ReadLine());
            byte In = 0;
            byte Out = 0;


            while (N >= 1) {

                N--;
                sbyte X = sbyte.Parse(Console.ReadLine());

                if (X >= 10 && X <= 20) {

                    In++;
                }
                else {
                    Out++;
                }    

            }

            Console.WriteLine($"{In} in");
            Console.WriteLine($"{Out} out");

        }//fim main
    }
}
