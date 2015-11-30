using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(adicao(10, 15));
            Console.WriteLine(subtracao(20, 30));
            Console.WriteLine(multiplicacao(27, 3));
            Console.WriteLine(divisao(80, 4));

            Console.ReadKey();

        }

        static decimal adicao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultadoAdicao;

            return resultadoAdicao = primeiroNumero + segundoNumero;
        }

        static decimal subtracao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultadoSubtracao;

            return resultadoSubtracao = primeiroNumero - segundoNumero;
        }
        static decimal multiplicacao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultadoMultiplicacao;

            return resultadoMultiplicacao = primeiroNumero * segundoNumero;
        }
        static decimal divisao(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultadoDivisao;

            return resultadoDivisao = primeiroNumero / segundoNumero;
        }
    }
}
