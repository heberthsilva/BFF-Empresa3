using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Business.Models;

namespace Service
{
    public class TermoUsoService : ITermoUsoService
    {
        private readonly ITermoUsoGateway _termoUsoGateway;

        public TermoUsoService(
            ITermoUsoGateway termoUsoGateway)
        {
            _termoUsoGateway = termoUsoGateway;
        }

        public TermoUsoService()
        {
        }

        public DefaultRetorno VerificarSessaoTermoUso(string ip)
            => _termoUsoGateway.VerificarSessaoTermoUso(ip);
        public DefaultRetorno AceiteTermoUso(AceiteTermoUso aceite)
            => _termoUsoGateway.AceiteTermoUso(aceite);
        public RetornoConsultaTermoDeUso ConsultaTermoDeUso(int TipoTermoUso)
            => _termoUsoGateway.ConsultaTermoDeUso(TipoTermoUso);
    }
}
