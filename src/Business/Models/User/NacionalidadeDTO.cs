using System;
using System.Collections.Generic;

namespace Business.Models.User
{
    public class NacionalidadeDTO
    {
        public short CodigoNacionalidade { get; set; }
        public string Nacionalidade { get; set; }
        public bool NacionalidadeInativo { get; set; }
    }
}
