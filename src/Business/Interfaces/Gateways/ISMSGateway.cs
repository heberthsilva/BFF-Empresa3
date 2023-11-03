using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using System.Threading.Tasks;

namespace Business.Interfaces.Gateways
{
    public interface ISMSGateway
    {
        DefaultRetorno ValidarSMS(AutenticaEmailSMS obj);
        Task<DefaultRetorno> EnviarcodigoSMS(EnviarCodigoSMS obj);

    }
}
