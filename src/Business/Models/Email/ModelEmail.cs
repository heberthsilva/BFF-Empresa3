using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Email
{
    public class ModelEmail
    {
        public string Email { get; set; }
        public long IdUsuario { get; set; }
    }

    public class AutenticaEmailSMS
    {
        public string Token { get; set; }
        public long IdUsuario { get; set; }
    }
      

}
