using System;

namespace Business.Models.User
{
    public class User
    {
        public bool SucessoInclusao { get; set; }
        public long CodigoUsuario { get; set; }
        public string CPFUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeFantasia { get; set; }
        public int CodigoCanal { get; set; }
        public string DataNascimentoUsuario { get; set; }
        public string SexoUsuario { get; set; }
        public string DataCadastroUsuario { get; set; }
        public bool UsarioInativo { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public string SenhaAntiga { get; set; }
        public string SenhaNova { get; set; }
        public string TokenUsuario { get; set; }
        public string NumeroDDD { get; set; }
        public string NumeroTelefone { get; set; }
        public string CNPJUsuario { get; set; }
        public DateTime DataFundacao { get; set; }
        public decimal RendaAnual { get; set; }
        public string CnaePrincipal { get; set; }
        public int TipoEmpresa { get; set; }
        public bool IsCPF { get; set; }
        public string PushTokenUsuario { get; set; }
        public bool? ExportadoErp { get; set; }
        public DateTime? DataExportadoErp { get; set; }
        public EnderecoUsuarioDTO enderecoUsuario { get; set; }
        public int CodigoProgramaFidelidade { get; set; }
        public DateTime? DtAdesaoFidelidade { get; set; }

        public string CodigoPromocional { get; set; }

        public int AptoParaCadastroFidelidade { get; set; }

        public int creditoConfianca { get; set; }

        public int PodeUsarCreditoConfianca { get; set; }

        public int QuerUsarCreditoConfianca { get; set; }

        public int AceiteCreditoConfianca { get; set; }

        public bool usuarioBlakList { get; set; }

        public OrgaoEmissorDTO OrgaoEmissor { get; set; }

        public EstadoCivilDTO EstadoCivil { get; set; }

        public NacionalidadeDTO Nacionalidade { get; set; }

        public UFDTO UFEmissor { get; set; }
        public bool EmailAutenticado { get; set; }
        public string pushTokenUsuario { get; set; }
        public string tokenPoliticaPrivacidade { get; set; }
        public string tokenTermoDeUso { get; set; }
        public string tokenUsuario { get; set; }
        public string NomeMae { get; set; }
        public bool TelefoneAutenticado { get; set; }
        public string OsDispositivo { get; set; }
        public string IdDispositivo { get; set; }
        public string NomeDispositivo { get; set; }
        public string IpDispositivo { get; set; }
        public bool exibirServicosDigitais { get; set; }

        public string NomeEmpresa { get; set; }
    }

   public class UserMarkII
    {
        public string CNPJUsuario { get; set; }
        public long CodigoUsuario { get; set; }
        public string CPFUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public EnderecoUsuarioDTO enderecoUsuario { get; set; }
        public bool exibirServicosDigitais { get; set; }
        public bool IsCPF { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeUsuario { get; set; }
        public string NumeroDDD { get; set; }
        public string NumeroTelefone { get; set; }
        public bool TelefoneAutenticado { get; set; }
        public bool EmailAutenticado { get; set; }
        public string pushTokenUsuario { get; set; }
        public string tokenPoliticaPrivacidade { get; set; }
        public string tokenTermoDeUso { get; set; }
        public string tokenUsuario { get; set; }

    }

}
