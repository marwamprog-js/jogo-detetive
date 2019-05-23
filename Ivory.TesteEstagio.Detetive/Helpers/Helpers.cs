using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive.Helpers
{
    public class Helpers
    {
        /* 
         * Metodo recebe o número da resposta avalida e 
         * retorna o texto de acordo com o número resposta.
         */
        public static string VerificaResposta(int _resposta)
        {
            string resposta = "";
            switch (_resposta)
            {
                case 0:
                    resposta = "Todos corretos, você solucionou o caso";
                    break;
                case 1:
                    resposta = "Suspeito incorreto";
                    break;
                case 2:
                    resposta = "Local incorreto";
                    break;
                case 3:
                    resposta = "Arma incorreta";
                    break;
            }

            return resposta;
        }

        //Método retorna o suspeito selecionado
        public static string RetornaSuspeito(int _suspeito)
        {
            string resposta = "";
            switch (_suspeito)
            {
                case 1:
                    resposta = "Advogado Sr. Marinho";
                    break;
                case 2:
                    resposta = "Chef. de Cozinha Tony Gourmet";
                    break;
                case 3:
                    resposta = "Coveiro Sérgio Sortuno";
                    break;
                case 4:
                    resposta = "Dançarina Srta. Rosa";
                    break;
                case 5:
                    resposta = "Florista Dona Branca";
                    break;
                case 6:
                    resposta = "Médica Dona Violeta";
                    break;
                case 7:
                    resposta = "Mordomo James";
                    break;
                case 8:
                    resposta = "Sargento Bigode";
                    break;
            }

            return resposta;
        }

        //Método retorna o local selecionado
        public static string RetornaLocal(int _local)
        {
            string resposta = "";
            switch (_local)
            {
                case 1:
                    resposta = "Biblioteca";
                    break;
                case 2:
                    resposta = "Cozinha";
                    break;
                case 3:
                    resposta = "Hall";
                    break;
                case 4:
                    resposta = "Escritório";
                    break;
                case 5:
                    resposta = "Sala de estar";
                    break;
                case 6:
                    resposta = "Sala de jantar";
                    break;
                case 7:
                    resposta = "Sala de música";
                    break;
                case 8:
                    resposta = "Salão de festas";
                    break;
                case 9:
                    resposta = "Salão de Jogos";
                    break;
            }

            return resposta;
        }

        //Método retorna arma selecionado
        public static string RetornaArma(int _arma)
        {
            string resposta = "";
            switch (_arma)
            {
                case 1:
                    resposta = "Castiçal";
                    break;
                case 2:
                    resposta = "Cano";
                    break;
                case 3:
                    resposta = "Chave inglesa";
                    break;
                case 4:
                    resposta = "Corda";
                    break;
                case 5:
                    resposta = "Revólver";
                    break;
                case 6:
                    resposta = "Faca";
                    break;
            }

            return resposta;
        }

        //Método responsável pela pergunta do suspeito
        public static void PerguntaSuspeito()
        {
            Console.WriteLine("Digite o número do SUSPEITO do crime.: ");
            Console.WriteLine("1 - Advogado Sr. Marinho\n" +
                "2 - Chef. de Cozinha Tony Gourmet\n" +
                "3 - Coveiro Sérgio Sortuno\n" +
                "4 - Dançarina Srta. Rosa\n" +
                "5 - Florista Dona Branca\n" +
                "6 - Médica Dona Violeta\n" +
                "7 - Mordomo James\n" +
                "8 - Sargento Bigode\n");
        }

        //Método responsável pela pergunta do local
        public static void PerguntaLocal()
        {
            Console.WriteLine("Digite o número do LOCAL do crime.: ");
            Console.WriteLine("1 - Biblioteca\n" +
                "2 - Cozinha\n" +
                "3 - Hall\n" +
                "4 - Escritório\n" +
                "5 - Sala de estar\n" +
                "6 - Sala de jantar\n" +
                "7 - Sala de música\n" +
                "8 - Salão de festas\n" +
                "9 - Salão de Jogos\n");
        }

        //Método responsável pela pergunta da arma
        public static void PerguntaArma()
        {
            Console.WriteLine("Digite o número da ARMA do crime.: ");
            Console.WriteLine("1 - Castiçal\n" +
                "2 - Cano\n" +
                "3 - Chave inglesa\n" +
                "4 - Corda\n" +
                "5 - Revólver\n" +
                "6 - Faca\n");
        }

        
    }
}
