using Business.Models;

namespace Business.Interfaces.Services
{
    public interface IMapaService
    {
        DefaultRetorno GetParadasPorCoordenadas(string latitude, string longitude);
    }
}
