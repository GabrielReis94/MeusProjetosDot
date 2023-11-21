using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    public class ExemplosVariaveis
    {
        public static void ExemploMensagemSaudacao()
        {
            string NomePessoa = "Heloisa Lopes";
            string msg = "Seja bem vinda " + NomePessoa;

            Console.WriteLine(msg);
        }
        public static void ExemploMensagemSaudacao2()
        {
            Console.WriteLine("Informe o Nome :");
            string NomePessoa = Console.ReadLine();

            string msg = "Seja Bem Vindo " + NomePessoa;
            Console.WriteLine(msg);
        }
        public static void CalculoMediaSimples()
        {
            double nota1 = 6.7;
            double nota2 = 7.7;

            double media = (nota1 + nota2) / 2;
            Console.WriteLine("A Media é " + media);
        }
    }
}
