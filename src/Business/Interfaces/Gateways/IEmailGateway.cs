using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;
using Business.Models.Email;

namespace Business.Interfaces.Gateways
{
    public interface IEmailGateway
    {
        DefaultRetorno EnviarEmailRecadastroSenha(string email);
        DefaultRetorno ValidarCodigoEmail(AutenticaEmailSMS obj);
        DefaultRetorno EnviarCodigoEmail(ModelEmail obj);
    }
}
