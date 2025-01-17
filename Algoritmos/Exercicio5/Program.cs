using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio5 {
    internal class Program {
        static void Main(string[] args) {

            short senha = 2002;
            short senhaUsuario = 0;

            senhaUsuario = short.Parse(Console.ReadLine());

            while (senha != senhaUsuario) {

                Console.WriteLine("Senha Invalida");
                senhaUsuario = short.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
