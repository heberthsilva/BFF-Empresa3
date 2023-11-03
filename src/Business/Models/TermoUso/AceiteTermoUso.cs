using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class AceiteTermoUso
    {
        public bool SucessoInclusao { get; set; }
        public long CodigoUsuario { get; set; }
        public string token { get; set; }
        public int TipoTermo { get; set; }

        public long CodigoUsuarioTermo { get; set; }
        public short CodigoTermo { get; set; }

        public DateTime DataAceite { get; set; }
        public string DataAceiteFormat
        {
            get
            {
                return DataAceite.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
        public string ip { get; set; }
    }
}
