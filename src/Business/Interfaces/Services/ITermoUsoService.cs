using Business.Models;

namespace Business.Interfaces.Services
{
    public interface ITermoUsoService
    {
        DefaultRetorno VerificarSessaoTermoUso(string ip);
        DefaultRetorno AceiteTermoUso(AceiteTermoUso aceite);
        RetornoConsultaTermoDeUso ConsultaTermoDeUso(int TipoTermoUso);
    }
}
