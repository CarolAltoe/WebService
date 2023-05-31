using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ProdutorWS
{
    /// <summary>
    /// Descrição resumida de WSCalculadora1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCalculadora1 : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Calculadora(decimal v1, decimal v2, char op)
        {
            decimal resultado;

            if (op.Equals('+'))
            {
                resultado = v1 + v2;
            } else if (op.Equals('-'))
            {
                resultado = v1 - v2;
            }
            else if (op.Equals('*'))
            {
                resultado = v1 * v2;
            }
            else if (op.Equals('/'))
            {
                if(v2 == 0)
                {
                    return 0;
                }
                resultado = v1 / v2;
            }
            else
            {
                return 0;
            }

            return resultado;
        }

        [WebMethod]
        public int Fatorial(int v1)
        {
            if(v1 <= 1)
            {
                return 1;
            } else
            {
                return v1 * Fatorial(v1 - 1);
            }
        }

        [WebMethod]
        public string Imc(decimal altura, decimal peso)
        {
            decimal imc;
            string mensagem;

            imc = peso /(altura * altura);

            if (imc < 17)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está Muito abaixo do peso";
            } 
            else if (17 <= imc && imc <= 18.49m )
            {
                mensagem = "Seu Imc é : " + imc + ". Você está Abaixo do peso";
            }
            else if (18.50m <= imc && imc <= 24.99m)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está Peso normal";
            } 
            else if (25 <= imc && imc <= 29.99m)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está Acima do peso";
            } 
            else if (30 <= imc && imc <= 34.99m)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está com Obesidade I";
            } 
            else if (35 <= imc && imc <= 39.99m)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está com Obesidade II (severa)";
            } 
            else if (40 <= imc)
            {
                mensagem = "Seu Imc é : " + imc + ". Você está com Obesidade III (mórbida)";
            } 
            else
            {
                mensagem = "Valor inválido!";
            }

            return mensagem;
        }


        [WebMethod]
        public decimal Conversao(decimal valorMetros, string tipoMedida)
        {
            decimal resultado = 0;

            if (tipoMedida == "quilometros")
            {
                resultado = (decimal)(valorMetros / 1000m);
            }
            else if (tipoMedida == "centimetros")
            {
                resultado = (decimal)(valorMetros / 0.01m);
            }
            else if (tipoMedida == "milimetros")
            {
                resultado = (decimal)(valorMetros / 0.001m);
            }
            else if (tipoMedida == "decimetros")
            {
                resultado = (decimal)(valorMetros / 0.1m);
            }

            return resultado;
        }

    }
}
