using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Business.Models;

namespace Service
{
    public class MapaService : IMapaService
    {
        private readonly IMapaGateway _mapaGateway;

        public MapaService(
            IMapaGateway mapaGateway)
        {
            _mapaGateway = mapaGateway;
        }

        public DefaultRetorno GetParadasPorCoordenadas(string latitude, string longitude)
           => _mapaGateway.GetParadasPorCoordenadas(latitude, longitude);        
    }
}
