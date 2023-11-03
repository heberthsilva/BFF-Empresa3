using Business.Interfaces.Gateways;
using Business.Models;
using Business.Models.Email;
using Newtonsoft.Json;

namespace Infrastructure.Gateways
{
    public class EmailGateway : GatewayBase, IEmailGateway
    {

        public DefaultRetorno EnviarEmailRecadastroSenha(string email)
        {
            var NewUrl = Globals.Empresa3Api + "Email/EnviarEmailRecadastroSenha?email=" + email;

            var Serialized = JsonConvert.SerializeObject(email);

            var Response = SendGet(NewUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.ToString());

            return resultado;
        }

        public DefaultRetorno ValidarCodigoEmail(AutenticaEmailSMS obj)
        {
            var NewUrl = Globals.AlteraUserApi + "Autenticacao/ValidarCodigoEmail?token=" + obj.Token + "&idUsuario=" + obj.IdUsuario;            

            var Response = SendGet(NewUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.ToString());

            return resultado;
        }


        public DefaultRetorno EnviarCodigoEmail(ModelEmail obj)
        {
            var NewUrl = Globals.AlteraUserApi + "Email/EnviarEmail";

            var Serialized = JsonConvert.SerializeObject(obj);            

            var Response = SendPost(NewUrl, Serialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.Content.ToString());

            return resultado;
        }
    }
}
