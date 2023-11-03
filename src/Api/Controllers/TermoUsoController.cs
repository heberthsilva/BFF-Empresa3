using AutoMapper;
using Business.Interfaces.Services;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Service;

namespace Api.Controllers
{
    [Route("TermoUso")]
    public class TermoUsoController : Controller
    {
        private readonly ITermoUsoService _termoUsoService;
        public TermoUsoController(
            ITermoUsoService termoUsoService
            )
        {
            _termoUsoService = termoUsoService;
        }

        /// <summary>
        /// Consulta Termo de Uso
        /// </summary>
        [HttpGet("ConsultaTermoDeUso")]
        public RetornoConsultaTermoDeUso ConsultaTermoDeUso(int TipoTermoUso)
        {
           var retorno = _termoUsoService.ConsultaTermoDeUso(TipoTermoUso);
            return retorno;
        }

        /// <summary>
        /// Aceite Termo Uso
        /// </summary>
        [HttpPost]
        [Route("AceiteTermoUso")]
        public DefaultRetorno AceiteTermoUso([FromBody] AceiteTermoUso aceite)
        {
            var response = _termoUsoService.AceiteTermoUso(aceite);
            return response;
        }
        /// <summary>
        /// Verifica Sessao Termo de Uso
        /// </summary>
        [HttpGet]
        [Route("VerificarSessaoTermoUso")]
        public DefaultRetorno VerificarSessaoTermoUso(string ip)
        {
            var response = _termoUsoService.VerificarSessaoTermoUso(ip);
            return response;
        }
    }

}

