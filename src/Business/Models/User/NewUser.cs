using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.User
{
    public class NewUser
    {
        public string EmailUsuario { get; set; }
        public string NumeroDDD { get; set; }
        public string NumeroTelefone { get; set; }
        public bool IsCPF { get; set; }
        public string CPFUsuario { get; set; }
        public string CNPJUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string DataNascimentoUsuario { get; set; }        
        public string NomeUsuario { get; set; }
        public string NomeFantasia { get; set; }
        public string SexoUsuario { get; set; }
        public string DataCadastroUsuario { get; set; }
        public long? CodigoUsuario { get; set; }
        public string TokenUsuario { get; set; }
        public int CodigoCanal { get; set; }
        public string OsDispositivo { get; set; }
        public string IdDispositivo { get; set; }
        public string NomeDispositivo { get; set; }
        public string IpDispositivo { get; set; }

        


    }
}
