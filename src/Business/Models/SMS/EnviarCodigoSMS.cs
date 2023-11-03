using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.SMS
{
    public class EnviarCodigoSMS
    {
        public string DDD { get; set; }
        public string numeroTel { get; set; }
        public long idUsuario { get; set; }
    }
}
