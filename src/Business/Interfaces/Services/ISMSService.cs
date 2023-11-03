using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;

namespace Business.Interfaces.Services
{
    public interface ISMSService
    {
        DefaultRetorno ValidarSMS(AutenticaEmailSMS obj);
        Task<DefaultRetorno> EnviarcodigoSMS(EnviarCodigoSMS obj);

    }
}
