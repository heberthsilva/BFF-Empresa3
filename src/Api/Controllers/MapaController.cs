using Business.Interfaces.Services;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Mapa")]
    public class MapaController : Controller
    {

        private readonly IMapaService _mapaService;
        public MapaController(
            IMapaService mapaService
            )
        {
            _mapaService = mapaService;
        }

        [HttpGet("GetParadasPorCoordenadas")]
        public DefaultRetorno GetParadasPorCoordenadas(string latitude, string longitude)
        {
            var response = _mapaService.GetParadasPorCoordenadas(latitude, longitude);
            return response;
        }
    }
}
