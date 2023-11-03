using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.User
{
    public class SenhaDTO
    {
        public long CodigoUsuario { get; set; }
        public string SenhaAntiga { get; set; }
        public string SenhaNova { get; set; }
        public string TokenUsuario { get; set; }

    }
}
