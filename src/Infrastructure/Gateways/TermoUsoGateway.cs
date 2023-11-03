using Business.Interfaces.Gateways;
using Business.Models;
using Newtonsoft.Json;

namespace Infrastructure.Gateways
{
    public class TermoUsoGateway : GatewayBase, ITermoUsoGateway
    {
        public RetornoConsultaTermoDeUso ConsultaTermoDeUso(int TipoTermoUso)
        {
            var NewTermoUrl = Globals.TermoUsoApi + "TermoUso/ConsultaAceiteTermoUso?TipoTermoUso=" + TipoTermoUso;

            var TermoSerialized = JsonConvert.SerializeObject(TipoTermoUso);

            var TermoResponse = SendGet(NewTermoUrl);

            var resultado = JsonConvert.DeserializeObject<RetornoConsultaTermoDeUso>(TermoResponse.ToString());

            return resultado;
        }
        public DefaultRetorno VerificarSessaoTermoUso(string ip)
        {
            //Criação Usando Monolito
            var VerificarSessaoTermoUsoUrl = Globals.TermoUsoApi + "TermoUso/VerificarSessaoTermoUso?ip="+ip;

            var VerificarSessaoTermoUsoResponse = SendGet(VerificarSessaoTermoUsoUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(VerificarSessaoTermoUsoResponse);

            return resultado;
        }

        public DefaultRetorno AceiteTermoUso(AceiteTermoUso aceite)
        {
            var AceiteTermoUrl = Globals.TermoUsoApi + "TermoUso/AceiteTermoUso";
            var AceiteTermoSerialized = JsonConvert.SerializeObject(aceite);

            var AceiteTermoResponse = SendPost(AceiteTermoUrl, AceiteTermoSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(AceiteTermoResponse.Content.ToString());
            return resultado;
        }
    }

}
