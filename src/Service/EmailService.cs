using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;

namespace Service
{
    public class EmailService: IEmailService
    {
        private readonly IEmailGateway _emailGateway;

        public EmailService(
            IEmailGateway emailGateway)
        {
            _emailGateway = emailGateway;
        }

        public DefaultRetorno EnviarEmailRecadastroSenha(string email)
           => _emailGateway.EnviarEmailRecadastroSenha(email);

        public DefaultRetorno ValidarCodigoEmail(AutenticaEmailSMS obj)
           => _emailGateway.ValidarCodigoEmail(obj);

        public DefaultRetorno EnviarCodigoEmail(ModelEmail obj)
           => _emailGateway.EnviarCodigoEmail(obj);
    }
}
