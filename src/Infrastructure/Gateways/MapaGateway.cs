using Business.Interfaces.Gateways;
using Business.Models;
using Newtonsoft.Json;

namespace Infrastructure.Gateways
{
    public class MapaGateway : GatewayBase, IMapaGateway
    {

        public DefaultRetorno GetParadasPorCoordenadas(string latitude, string longitude)
        {
            var NewUrl = Globals.Empresa3Api + "Mapa/GetParadasPorCoordenadas?latitude=" + latitude + "&longitude=" + longitude;
            
            var Response = SendGet(NewUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(Response.ToString());

            return resultado;
        }
    }
}
