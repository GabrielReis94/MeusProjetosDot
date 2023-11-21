using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    public class ExemplosOperadoresComparacao
    {
        public static void TestesOperadoresIgualdade()
        {
            // 01 - Entrada de dados (Input)
            int a = 9;
            int b = 10;

            //Processamento
            bool igualdade1 = a == b;


            //Resultado 
            Console.WriteLine("a = : " + igualdade1);
            
        }
        public static void TestesOperadoresDiferenca()
        {
            //Entrada dos dados (Input)
            Console.WriteLine("Informe uma Letra:");
            string letra = Console.ReadLine();
            string minhaletra = "x";

            // Processamento
            bool diferenca = letra != minhaletra;

            //Resultado
            Console.WriteLine("Letra = " + letra);
            Console.WriteLine("Minha letra = " + minhaletra);
            Console.WriteLine("é diferente ?" + diferenca);
        }
        public static void TestesOperadoresMaiorouIgual()
        {
            // entrada de dados (input)
            
            double nota1 = 7.0;
            double nota2 = 5.0;
            double nota3 = 6.0;
            double nota4 = 5.0;

            // Processamento
            double MediaAprovacao = 6.0;

            double soma = nota1 + nota2 + nota3 + nota4;
            double MediaAluno = soma / 4.0;

            bool SituacaoAluno = MediaAluno >= MediaAprovacao;

            //Resultado

            Console.WriteLine("A Media de Aprovacação é: " +MediaAprovacao);
            Console.WriteLine("A nota do Aluno é: " + MediaAluno);
            Console.WriteLine("Aprovado? " + SituacaoAluno);

        }
        public static void TestesOperadoresMenor()
        {
            //Entrada de dados (input)
            int IdadeAvaliada = 15;

            //Processamento
            int IdadeMaioridade = 18;
            bool enMenor = IdadeAvaliada < IdadeMaioridade;

            //Resultado 

            Console.WriteLine("A Pessoa Avaliada é maior ou menor ? " + enMenor);



        }
    }

      
}
