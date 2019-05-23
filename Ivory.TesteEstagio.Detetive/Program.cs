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
            int finalizar = 1;

            Console.WriteLine("JOGO - DETETIVE\n" +
                "--------------------------------------------------\n");

            try
            {

                do
                {
                    //Coletar o SUSPEITO escolhido pelo jogador
                    Helpers.Helpers.PerguntaSuspeito();

                    suspeito = int.Parse(Console.ReadLine());
                    /*
                    * Caso o n�mero informado for menor ou maior do que as op��es
                    * dadas, entrara em um loop at� que seja informado o valor 
                    * corretamente.
                    */
                    while (suspeito < 1 || suspeito > 8)
                    {
                        Console.WriteLine("ATENC�O: Suas op��es s�o de 1 a 8!" +
                            "\nPrecione qualquer tecla para continuar...\n");
                        Console.ReadKey();
                        Console.Clear();
                        Helpers.Helpers.PerguntaSuspeito();
                        suspeito = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    //Coletar o LOCAL escolhido pelo jogador
                    Helpers.Helpers.PerguntaLocal();

                    local = int.Parse(Console.ReadLine());
                    /*
                    * Caso o n�mero informado for menor ou maior do que as op��es
                    * dadas, entrara em um loop at� que seja informado o valor 
                    * corretamente.
                    */
                    while (local < 1 || local > 9)
                    {
                        Console.WriteLine("ATENC�O: Suas op��es s�o de 1 a 9!" +
                            "\nPrecione qualquer tecla para continuar...\n");
                        Console.ReadKey();
                        Console.Clear();
                        Helpers.Helpers.PerguntaLocal();
                        local = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    //Coletar o ARMA escolhido pelo jogador
                    Helpers.Helpers.PerguntaArma();

                    arma = int.Parse(Console.ReadLine());
                    /*
                     * Caso o n�mero informado for menor ou maior do que as op��es
                     * dadas, entrara em um loop at� que seja informado o valor 
                     * corretamente.
                     */
                    while (arma < 1 || arma > 6)
                    {
                        Console.WriteLine("ATENC�O: Suas op��es s�o de 1 a 6!" +
                            "\nPrecione qualquer tecla para continuar...\n");
                        Console.ReadKey();
                        Console.Clear();
                        Helpers.Helpers.PerguntaArma();
                        arma = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();


                    //-------------------------------------------------------------------------------------


                    //Exibe as op��es escolhidas pelo jogador
                    Console.WriteLine("Escolhidos: \n" +
                        "Suspeito: " + suspeito + " - " + Helpers.Helpers.RetornaSuspeito(suspeito) +
                        "\nLocal: " + local + " - " + Helpers.Helpers.RetornaLocal(local) +
                        "\nArma: " + arma + " - " + Helpers.Helpers.RetornaArma(arma)
                        );

                    resposta = testemunha.Interrogar(suspeito, local, arma);

                    /*
                     Caso a resposta seja diferente de 0, ou seja, 
                     diferente de "Todos corretos, voc� solucionou o caso"
                     O c�digo vai exibir apenas a resposta sem o n�mero de tentativas.
                     */
                    if (resposta != 0)
                    {
                        Console.WriteLine("\n\nResposta.: " + Helpers.Helpers.VerificaResposta(resposta));
                        Console.WriteLine("\nDigite 1 para continuar ou 0 para finalizar");
                        finalizar = int.Parse(Console.ReadLine());
                        while (finalizar < 0 || finalizar > 1)
                        {
                            Console.WriteLine("ATENC�O: Suas op��es s�o de 1 a 0!");
                            Console.WriteLine("\nDigite 1 para continuar ou 0 para finalizar");
                            finalizar = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n\nResposta.: " + Helpers.Helpers.VerificaResposta(resposta));
                        Console.WriteLine("N�mero de Tentativas: " + testemunha.ObterNumeroInterogatoriosRealizados());
                        Console.WriteLine("\nPressione qualquer tecla finalizar...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                } while (resposta != 0 && finalizar != 0);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro: Programa ser� fechado!" +
                    "\nDeve-se digitar n�meros inteiros ao inv�s de letras ou caracteres.");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Obrigado por jogar!!!" +
                "\nVolte sempre!!!");
            Console.ReadKey();

        }
        
    }
}
