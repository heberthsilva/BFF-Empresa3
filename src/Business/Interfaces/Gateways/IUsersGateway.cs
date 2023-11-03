using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Business.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace Business.Interfaces.Gateways
{
    public interface IUsersGateway
    {
        DefaultRetornoUserMarkII VerificarSessao(string token, int CodCanal);
        DefaultRetornoUserMarkII NovoUsuario(NewUser newUser);
        DefaultRetornoUserMarkII Login(LoginDTO obj);
        DefaultRetorno AutenticaTelefone(EnviarSMS obj);
        DefaultRetorno AtualizarUsuario(User user);
        DefaultRetorno AlterarSenha(SenhaDTO user);
        DefaultRetorno AtualizaEmail(ModelAtualizaEmail updateUser);
        DefaultRetorno AtualizaTelefone(User updateUser);
    }
}
