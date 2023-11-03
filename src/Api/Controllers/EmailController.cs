using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Email")]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        public EmailController(
            IEmailService emailService
            )
        {
            _emailService = emailService;
            
        }

        [HttpGet("EnviarEmailRecadastroSenha")]
        public DefaultRetorno EnviarEmailRecadastroSenha(string email)
        {
            var response = _emailService.EnviarEmailRecadastroSenha(email);
            return response;
        }

        [HttpGet("ValidarCodigoEmail")]
        public DefaultRetorno ValidarCodigoEmail(AutenticaEmailSMS obj)
        {
            var response = _emailService.ValidarCodigoEmail(obj);
            return response;
        }

        [HttpPost("EnviarCodigoEmail")]
        public DefaultRetorno EnviarCodigoEmail([FromBody] ModelEmail obj)  
        {
            var response = _emailService.EnviarCodigoEmail(obj);
            return response;
        }

    }
}
