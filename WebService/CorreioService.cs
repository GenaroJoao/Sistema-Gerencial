using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios;

namespace ERP.WebService
{
    internal class CorreioService
    {
       /* public string ConsultaCep(string Cep)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                try
                {
                    var endereco = ws.consultaCEP(Cep.Trim());
                    return $"{endereco.end}, {endereco.bairro}, {endereco.cidade} - {endereco.uf}, {endereco.cep}";

                }
                catch (Exception erro)
                {
                    return erro.Message.ToString();
                }
            }
        }*/
    }
}
