using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;
using Business.Models.Email;

namespace Business.Interfaces.Services
{
    public interface IEmailService
    {
        DefaultRetorno EnviarEmailRecadastroSenha(string email);
        DefaultRetorno ValidarCodigoEmail(AutenticaEmailSMS obj);
        DefaultRetorno EnviarCodigoEmail(ModelEmail obj);
    }
}
