using Business.Interfaces.Gateways;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Gateways
{
    public class SMSGateway : GatewayBase, ISMSGateway
    {
        public DefaultRetorno ValidarSMS(AutenticaEmailSMS obj)
        {
            //Criação Usando Monolito

            var NewUrl = Globals.AlteraUserApi + "Autenticacao/ValidarCodigoSMS?Token=" + obj.Token + "&IdUsuario=" + obj.IdUsuario;           

            var Response = SendGet(NewUrl);

            var resultado = new DefaultRetorno();

            resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.ToString());

            return resultado;

        }
        
        public async Task<DefaultRetorno> EnviarcodigoSMS(EnviarCodigoSMS obj)
        {   
            var NewUrl = Globals.AlteraUserApi + "Autenticacao/EnviarSMS";

            var Serialized = JsonConvert.SerializeObject(obj);

            var Response = SendPost(NewUrl, Serialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.Content.ToString());

            return resultado;

        }
    }

}
