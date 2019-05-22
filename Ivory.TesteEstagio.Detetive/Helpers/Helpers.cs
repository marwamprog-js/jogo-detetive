using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivory.TesteEstagio.Detetive.Helpers
{
    public class Helpers
    {
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
    }
}
