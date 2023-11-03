using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class RetornoConsultaTermoDeUso
    {
        public string Mensagem { get; set; }
        public string MensagemLog { get; set; }
        public string MensagemStatus { get; set; }
        public int Status { get; set; }
        public List<TermoDeUso> ListaObjeto { get; set; }
    }
    public class TermoDeUso
    {
        public int codigo { get; set; }
        public string DescTermoDeUso { get; set; }
        public DateTime DataCadastro { get; set; }
        public int ExisteTermoUso { get; set; }
    }
}
