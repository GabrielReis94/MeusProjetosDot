using Microsoft.VisualBasic;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Sources;
using System.Xml;

namespace MeuPrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DesafiodasVariaveis();
            // DesafioComparacao();
            // DetalhandoLimitesNumericos.AnalisandoDados();
           
        }
        static void DesafiodasVariaveis()
        {
            Console.WriteLine("trabalhando com variaveis\n");
            ExemplosVariaveis.ExemploMensagemSaudacao();
            ExemplosVariaveis.ExemploMensagemSaudacao2();
            ExemplosVariaveis.CalculoMediaSimples();
        }

        static void DesafioComparacao()
        {
            Console.WriteLine("Trabalhando com operadores de Comparação\n");
            //  ExemplosOperadoresComparacao.TestesOperadoresIgualdade();
            //  ExemplosOperadoresComparacao.TestesOperadoresDiferenca();
            // ExemplosOperadoresComparacao.TestesOperadoresMaiorouIgual();
            //ExemplosOperadoresComparacao.TestesOperadoresMenor();
        }




    }
}
