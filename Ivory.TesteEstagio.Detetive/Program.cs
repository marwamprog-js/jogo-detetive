using System;
using Ivory.TesteEstagio.Detetive.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive
{
    class Program
    {
        static void Main(string[] args)
        {
            var testemunha = new Testemunha();

            //Variaveis 
            int suspeito;
            int local;
            int arma;
            int resposta;

            do
            {
                //Coletar o SUSPEITO escolhido pelo jogador
                Console.WriteLine("Escolha o SUSPEITO do crime.: ");
                Console.WriteLine("1 - Advogado Sr. Marinho\n" +
                    "2 - Chef. de Cozinha Tony Gourmet\n" +
                    "3 - Coveiro S�rgio Sortuno\n" +
                    "4 - Dan�arina Srta. Rosa\n" +
                    "5 - Florista Dona Branca\n" +
                    "6 - M�dica Dona Violeta\n" +
                    "7 - Mordomo James\n" +
                    "8 - Sargento Bigode\n");

                suspeito = int.Parse(Console.ReadLine());
                Console.Clear();

                //Coletar o LOCAL escolhido pelo jogador
                Console.WriteLine("Escolha o LOCAL do crime.: ");
                Console.WriteLine("1 - Biblioteca\n" +
                    "2 - Cozinha\n" +
                    "3 - Hall\n" +
                    "4 - Escrit�rio\n" +
                    "5 - Sala de estar\n" +
                    "6 - Sala de jantar\n" +
                    "7 - Sala de m�sica\n" +
                    "8 - Sal�o de festas\n" + 
                    "9 - Sal�o de Jogos\n");

                local = int.Parse(Console.ReadLine());
                Console.Clear();

                //Coletar o ARMA escolhido pelo jogador
                Console.WriteLine("Escolha a ARMA do crime.: ");
                Console.WriteLine("1 - Casti�al\n" +
                    "2 - Cano\n" +
                    "3 - Chave inglesa\n" +
                    "4 - Corda\n" +
                    "5 - Rev�lver\n" +
                    "6 - Faca\n");

                arma = int.Parse(Console.ReadLine());
                Console.Clear();

                //Exibe as op��es escolhidas pelo jogador
                Console.WriteLine("Escolhidos: \n" +
                    "Suspeito: " + suspeito + " - Local: " + local + " - Arma: " + arma);

                resposta = testemunha.Interrogar(suspeito, local, arma);

                /*
                 Caso a resposta seja diferente de 0, ou seja, 
                 diferente de "Todos corretos, voc� solucionou o caso"
                 O c�digo vai exibir apenas a resposta sem o n�mero de tentativas.
                 */
                if (resposta != 0)
                {
                    Console.WriteLine("\n\nResposta.: " + Helpers.Helpers.VerificaResposta(resposta));
                    Console.ReadKey();
                    Console.Clear();
                } else
                {
                    Console.WriteLine("\n\nResposta.: " + Helpers.Helpers.VerificaResposta(resposta));
                    Console.WriteLine("N�mero de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
                    Console.ReadKey();
                    Console.Clear();
                }
                

            } while (resposta != 0);

                        
        }
    }
}
