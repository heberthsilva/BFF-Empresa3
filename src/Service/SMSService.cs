using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;

namespace Service
{
    public class SMSService : ISMSService
    {
        private readonly ISMSGateway _SMSGateway;

        public SMSService(
            ISMSGateway smsGateway)
        {
            _SMSGateway = smsGateway;
        }

        public DefaultRetorno ValidarSMS(AutenticaEmailSMS obj)
            => _SMSGateway.ValidarSMS(obj);
        public async Task<DefaultRetorno> EnviarcodigoSMS(EnviarCodigoSMS obj)
            =>  await _SMSGateway.EnviarcodigoSMS(obj);
    }
}
