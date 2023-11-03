using Business.Interfaces.Gateways;
using Business.Interfaces.Services;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Business.Models.User;

namespace Service
{
    public class UsuarioService : IUserService
    {
        private readonly IUsersGateway _userGateway;

        public UsuarioService(
            IUsersGateway usrGateway)
        {
            _userGateway = usrGateway;
        }

        public DefaultRetornoUserMarkII NovoUsuario(NewUser newUser)
            =>  _userGateway.NovoUsuario(newUser);
        public DefaultRetorno AtualizarUsuario(User user)
            => _userGateway.AtualizarUsuario(user);
        public DefaultRetorno AlterarSenha(SenhaDTO user)
            => _userGateway.AlterarSenha(user);
        public DefaultRetornoUserMarkII VerificarSessao(string token, int CodCanal)
            => _userGateway.VerificarSessao(token,CodCanal); 
        public DefaultRetornoUserMarkII Login(LoginDTO obj)
            => _userGateway.Login(obj);
        public DefaultRetorno AutenticaTelefone(EnviarSMS obj)
            => _userGateway.AutenticaTelefone(obj);
         public DefaultRetorno AtualizaEmail(ModelAtualizaEmail updateUser)
            => _userGateway.AtualizaEmail(updateUser);
        public DefaultRetorno AtualizaTelefone(User updateUser)
            => _userGateway.AtualizaTelefone(updateUser);
    }
}
