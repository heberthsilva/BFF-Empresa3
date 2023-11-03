using System;
using System.Collections.Generic;

namespace Business.Models.User
{
    public class EstadoCivilDTO
    {
        public short CodigoEstadoCivil { get; set; }
        public string EstadoCivil { get; set; }
        public bool EstadoCivilInativo { get; set; }
    }
}
