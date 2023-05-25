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
        public string Calculadora(float v1, float v2, char op)
        {
            float resultado;

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
                    return "Não é possível dividir por 0";
                }
                resultado = v1 / v2;
            }
            else
            {
                return "Valor inválido!";
            }

            return resultado.ToString();
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
        public string Imc(float altura, float peso)
        {
            float imc;
            string mensagem;

            imc = peso /(altura * altura);

            if (imc < 17)
            {
                mensagem = "Muito abaixo do peso";
            } 
            else if (17 <= imc && imc <= 18.49 )
            {
                mensagem = "Imc: " + imc + "Abaixo do peso";
            }
            else if (18.50 <= imc && imc <= 24.99)
            {
                mensagem = "Imc: " + imc +  "Peso normal";
            } 
            else if (25 <= imc && imc <= 29.99)
            {
                mensagem = "Imc: " + imc + "Acima do peso";
            } 
            else if (30 <= imc && imc <= 34.99)
            {
                mensagem = "Imc: " + imc +  "Obesidade I";
            } 
            else if (35 <= imc && imc <= 39.99)
            {
                mensagem = "Imc: " + imc +  "Obesidade II (severa)";
            } 
            else if (40 <= imc)
            {
                mensagem = "Imc: " + imc +  "Obesidade III (mórbida)";
            } 
            else
            {
                mensagem = "Valor inválido!";
            }

            return mensagem;
        }


        [WebMethod]
        public float Conversao(float valorMetros, string tipoMedida)
        {
            float resultado = 0;

            if (tipoMedida == "quilometros")
            {
                resultado = (float)(valorMetros / 1000);
            }
            else if (tipoMedida == "centimetros")
            {
                resultado = (float)(valorMetros / 0.01);
            }
            else if (tipoMedida == "milimetros")
            {
                resultado = (float)(valorMetros / 0.001);
            }
            else if (tipoMedida == "decimetros")
            {
                resultado = (float)(valorMetros / 0.1);
            }

            return resultado;
        }

    }
}
