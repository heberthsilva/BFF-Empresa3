using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("SMS")]
    public class SMSController 
    {
        private readonly ISMSService _smsService;
        public SMSController(
            ISMSService smsService
            ) 
        {
            _smsService = smsService;
        }
        
        
        [HttpGet("ValidarCodigoSMS")]
        public DefaultRetorno ValidarSMS(AutenticaEmailSMS obj)
        {
            var response = _smsService.ValidarSMS(obj);
            return response;
        }
        
        [HttpPost("EnviarCodigoSMS")]
        public async Task<DefaultRetorno> EnviarcodigoSMS([FromBody] EnviarCodigoSMS obj)
        {
            var response = await _smsService.EnviarcodigoSMS(obj);
            return response;
        }

    }

}

