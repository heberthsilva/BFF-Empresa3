using System;
using System.Collections.Generic;

namespace Business.Models.User
{
    public class EnderecoUsuarioDTO
    {
        public long CodigoEnderecoUsuario { get; set; }
        public long CodigoUsuario { get; set; }
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public int NumeroLogradouro { get; set; }
        public string ComplementoLogradouro { get; set; }
        public string NomeBairro { get; set; }
        public string NomeMunicipio { get; set; }
        public short CodigoUF { get; set; }
        public string SiglaUF { get; set; }
        public string CEP { get; set; }
        public bool EnderecoPrincipal { get; set; }
        public int Ibge { get; set; }
        public string Referencia { get; set; }
        public string Pais { get; set; }
        public bool EnderecoCorrespondencia { get; set; }
    }
}
