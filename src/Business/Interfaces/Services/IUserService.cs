using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Business.Models.User;

namespace Business.Interfaces.Services
{
    public interface IUserService
    {
        DefaultRetorno AtualizarUsuario(User user);
        DefaultRetornoUserMarkII NovoUsuario(NewUser newUser);
        DefaultRetornoUserMarkII Login(LoginDTO obj);
        DefaultRetornoUserMarkII VerificarSessao(string token, int CodCanal);
        DefaultRetorno AutenticaTelefone(EnviarSMS obj);
        DefaultRetorno AlterarSenha(SenhaDTO user);
        DefaultRetorno AtualizaEmail(ModelAtualizaEmail updateUser);
        DefaultRetorno AtualizaTelefone(User updateUser);
    }
}
