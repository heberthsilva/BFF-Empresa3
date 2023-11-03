using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Business.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{    
    [Route("User")]
    public class UserController 
    {
        private readonly IUserService _userService;
        public UserController(
            IUserService userService
            ) 
        {
            _userService = userService;
        }

        /// <summary>
        /// Inclui Novo Usuario
        /// </summary>
        [HttpPost("NovoUsuario")]
        public DefaultRetornoUserMarkII NovoUsuario([FromBody] NewUser newUser)
        {
            var response =  _userService.NovoUsuario(newUser);
            return response;
        }

        [HttpPost("AtualizaEmail")]
        public DefaultRetorno AtualizaEmail([FromBody] ModelAtualizaEmail newUser)
        {
            var response =  _userService.AtualizaEmail(newUser);
            return response;
        }

        [HttpPost("AtualizaTelefone")]
        public DefaultRetorno AtualizaTelefone([FromBody] User newUser)
        {
            var response = _userService.AtualizaTelefone(newUser);
            return response;
        }

        [HttpPost("Login")]
        public DefaultRetornoUserMarkII Login([FromBody] LoginDTO obj)
        {
            var response = _userService.Login(obj);
            return response;
        }
        [HttpGet("VerificarSessao")]
        public DefaultRetornoUserMarkII VerificarSessao(string token, int CodCanal)
        {
            var response = _userService.VerificarSessao(token,CodCanal);
            return response;
        }

        [HttpPost("AutenticaTelefone")]
        public DefaultRetorno AutenticaTelefone([FromBody] EnviarSMS obj)
        {
            var response = _userService.AutenticaTelefone(obj);
            return response;
        }

        [HttpPost]
        [Route("AtualizarUsuario")]
        public DefaultRetorno AtualizarUsuario([FromBody] User user)
        {
            var response = _userService.AtualizarUsuario(user);
            return response;
        }

        [HttpPost]
        [Route("AlterarSenha")]
        public DefaultRetorno AlterarSenha([FromBody] SenhaDTO user)
        {
            var response = _userService.AlterarSenha(user);
            return response;
        }
    }

}
