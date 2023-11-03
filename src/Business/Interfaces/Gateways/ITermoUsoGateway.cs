using Business.Models;
using System.Threading.Tasks;

namespace Business.Interfaces.Gateways
{
    public interface ITermoUsoGateway
    {
        RetornoConsultaTermoDeUso ConsultaTermoDeUso(int TipoTermoUso);
        DefaultRetorno AceiteTermoUso(AceiteTermoUso aceite);
        DefaultRetorno VerificarSessaoTermoUso(string ip);
    }
}   
