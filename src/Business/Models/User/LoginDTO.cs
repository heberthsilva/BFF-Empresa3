using System;
using System.Collections.Generic;

namespace Business.Models.User
{
    public class LoginDTO
    {
        public string email { get; set; }
        public string senha { get; set; }
        public int codCanal { get; set; }
        public string OsDispositivo { get; set; }
        public string IdDispositivo { get; set; }
        public string NomeDispositivo { get; set; }
        public string IpDispositivo { get; set; }
    }


    public class RetornoLogin
    {
      public string NomePreferencial { get; set; }
     public string NomeMae { get; set; }
     public string NomePai{ get; set; }
     public string NumeroRG{ get; set; }
      public string NomeImpresso{ get; set; }
      public string DtEmissaoRG{ get; set; }
      public string Profissao{ get; set; }
      public string TipoOcupacao{ get; set; }
      public string NumeroBanco{ get; set; }
      public string NumeroAgencia{ get; set; }
      public string NumeroConta{ get; set; }
      public string NomeEmpresa{ get; set; }
      public string NegocioID{ get; set; }
      public string ProdutoID{ get; set; }
      public string DataVencimento{ get; set; }
      public string ValorRenda{ get; set; }
      public string IsPep{ get; set; }
      public string DataPep{ get; set; }
      public string TipoTelefone{ get; set; }
      public string Telefone{ get; set; }
      public string AceiteTermos{ get; set; }
      public string TokenTermoDeUso{ get; set; }
      public string TokenPoliticaPrivacidade{ get; set; }
      public string StatusConta{ get; set; }
      public string CodigoUsuarioBanco{ get; set; }
      public string CodigoConta{ get; set; }
      public string SenhaCarteira{ get; set; }
      public string QuantidadeCashInAbertos{ get; set; }
      public string TipoRevenda{ get; set; }
      public string RevendaSuspensa{ get; set; }
      public string TipoLoja{ get; set; }
      public string ExibirServicosDigitais{ get; set; }
      public string CodigoUsuario{ get; set; }
      public string CPFUsuario{ get; set; }
      public string NomeUsuario{ get; set; }
      public string NomeFantasia{ get; set; }
      public string CodigoCanal{ get; set; }
      public string DataNascimentoUsuario{ get; set; }
      public string SexoUsuario{ get; set; }
      public string DataCadastroUsuario{ get; set; }
      public string UsarioInativo{ get; set; }
      public string EmailUsuario{ get; set; }
      public string SenhaUsuario{ get; set; }
      public string SenhaAntiga{ get; set; }
      public string SenhaNova{ get; set; }
      public string TokenUsuario{ get; set; }
      public string NumeroDDD{ get; set; }
      public string NumeroTelefone{ get; set; }
      public string CNPJUsuario{ get; set; }
      public string DataFundacao{ get; set; }
      public string RendaAnual{ get; set; }
      public string CnaePrincipal{ get; set; }
      public string TipoEmpresa{ get; set; }
      public string IsCPF{ get; set; }
      public string PushTokenUsuario{ get; set; }
      public string ExportadoErp{ get; set; }
      public string DataExportadoErp{ get; set; }
      public string enderecoUsuario{ get; set; }
      public string CodigoProgramaFidelidade{ get; set; }
      public string DtAdesaoFidelidade{ get; set; }
      public string CodigoPromocional{ get; set; }
      public string AptoParaCadastroFidelidade{ get; set; }
      public string creditoConfianca{ get; set; }
      public string PodeUsarCreditoConfianca{ get; set; }
      public string QuerUsarCreditoConfianca{ get; set; }
      public string AceiteCreditoConfianca{ get; set; }
      public string usuarioBlakList{ get; set; }
      public string OrgaoEmissor{ get; set; }
      public string EstadoCivil{ get; set; }
      public string Nacionalidade{ get; set; }
      public string UFEmissor{ get; set; }
      public string TelefoneAutenticado{ get; set; }
      public string OsDispositivo{ get; set; }
      public string IdDispositivo{ get; set; }
      public string NomeDispositivo{ get; set; }
      public string IpDispositivo { get; set; }

    }
}
