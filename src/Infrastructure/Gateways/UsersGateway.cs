using Business.Interfaces.Gateways;
using Business.Models;
using Business.Models.Email;
using Business.Models.SMS;
using Business.Models.User;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Infrastructure.Gateways
{
    public class UsersGateway : GatewayBase, IUsersGateway
    {
        public DefaultRetornoUserMarkII NovoUsuario(NewUser newUser)
        {

            //Criação Usando Monolito
            var NewUserUrl = Globals.AlteraUserApi + "Usuario/NovoUsuario";

            var UserSerialized = JsonConvert.SerializeObject(newUser);

            var UserResponse = SendPost(NewUserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetornoUser>(UserResponse.Content.ToString());
            List<UserMarkII> usuarios = new List<UserMarkII>();

            foreach (var item in resultado.ListaObjeto)
            {
                var user = new UserMarkII();
                user.CNPJUsuario = item.CNPJUsuario;
                user.CodigoUsuario = item.CodigoUsuario;
                user.CPFUsuario = item.CPFUsuario;
                user.EmailUsuario = item.EmailUsuario;
                user.enderecoUsuario = item.enderecoUsuario;
                user.tokenUsuario = item.TokenUsuario;
                user.pushTokenUsuario = item.PushTokenUsuario;
                user.IsCPF = item.IsCPF;
                user.NomeFantasia = item.NomeFantasia;
                user.NomeUsuario = item.NomeUsuario;
                user.NumeroDDD = item.NumeroDDD;
                user.NumeroTelefone = item.NumeroTelefone;
                user.TelefoneAutenticado = item.TelefoneAutenticado;
                user.exibirServicosDigitais = item.exibirServicosDigitais;
                user.EmailAutenticado = item.EmailAutenticado;
                user.NomeEmpresa = item.NomeEmpresa;
                user.tokenPoliticaPrivacidade = item.tokenPoliticaPrivacidade;
                user.tokenTermoDeUso = item.tokenTermoDeUso;
                usuarios.Add(user);
            }
            var retorno = new DefaultRetornoUserMarkII();
            retorno.ListaObjeto.AddRange(usuarios);
            retorno.Mensagem = resultado.Mensagem;
            retorno.MensagemStatus = resultado.MensagemStatus;
            retorno.Status = resultado.Status;

            return retorno;

        }

        public DefaultRetornoUserMarkII Login(LoginDTO obj)
        {
            var NewUserUrl = Globals.LoginApi + "Login";

            var UserSerialized = JsonConvert.SerializeObject(obj);

            var UserResponse = SendPost(NewUserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetornoUser>(UserResponse.Content.ToString());
            
            List<UserMarkII> usuarios = new List<UserMarkII>();
            
            foreach (var item in resultado.ListaObjeto)
            {
                var user = new UserMarkII();
                user.CNPJUsuario = item.CNPJUsuario;
                user.CodigoUsuario = item.CodigoUsuario;
                user.CPFUsuario = item.CPFUsuario;
                user.EmailUsuario = item.EmailUsuario;
                user.enderecoUsuario = item.enderecoUsuario;
                user.tokenUsuario = item.TokenUsuario;
                user.pushTokenUsuario = item.PushTokenUsuario;
                user.IsCPF = item.IsCPF;
                user.NomeFantasia = item.NomeFantasia;
                user.NomeUsuario = item.NomeUsuario;
                user.NumeroDDD = item.NumeroDDD;
                user.NumeroTelefone = item.NumeroTelefone;
                user.TelefoneAutenticado = item.TelefoneAutenticado;             
                user.exibirServicosDigitais = item.exibirServicosDigitais;
                user.EmailAutenticado = item.EmailAutenticado;
                user.NomeEmpresa = item.NomeEmpresa;
                user.tokenPoliticaPrivacidade = item.tokenPoliticaPrivacidade;
                user.tokenTermoDeUso = item.tokenTermoDeUso;
                usuarios.Add(user);
            }
            var retorno = new DefaultRetornoUserMarkII();
            retorno.ListaObjeto.AddRange(usuarios);
            retorno.Mensagem = resultado.Mensagem;
            retorno.MensagemStatus = resultado.MensagemStatus;
            retorno.Status = resultado.Status;

            return retorno;

        }
        public DefaultRetornoUserMarkII VerificarSessao(string token, int CodCanal)
        {
            var NewUserUrl = Globals.LoginApi + "VerificarSessao?token="+token+ "&CodCanal="+ CodCanal;

            var UserResponse = SendGet(NewUserUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetornoUser>(UserResponse.ToString());

            List<UserMarkII> usuarios = new List<UserMarkII>();

            foreach (var item in resultado.ListaObjeto)
            {
                var user = new UserMarkII();
                user.CNPJUsuario = item.CNPJUsuario;
                user.CodigoUsuario = item.CodigoUsuario;
                user.CPFUsuario = item.CPFUsuario;
                user.EmailUsuario = item.EmailUsuario;
                user.enderecoUsuario = item.enderecoUsuario;
                user.tokenUsuario = item.TokenUsuario;
                user.pushTokenUsuario = item.PushTokenUsuario;
                user.IsCPF = item.IsCPF;
                user.NomeFantasia = item.NomeFantasia;
                user.NomeUsuario = item.NomeUsuario;
                user.NumeroDDD = item.NumeroDDD;
                user.NumeroTelefone = item.NumeroTelefone;
                user.TelefoneAutenticado = item.TelefoneAutenticado;
                user.exibirServicosDigitais = item.exibirServicosDigitais;
                user.EmailAutenticado = item.EmailAutenticado;
                user.NomeEmpresa = item.NomeEmpresa;
                user.tokenPoliticaPrivacidade = item.tokenPoliticaPrivacidade;
                user.tokenTermoDeUso = item.tokenTermoDeUso;
                usuarios.Add(user);
            }
            var retorno = new DefaultRetornoUserMarkII();
            retorno.ListaObjeto.AddRange(usuarios);
            retorno.Mensagem = resultado.Mensagem;
            retorno.MensagemStatus = resultado.MensagemStatus;
            retorno.Status = resultado.Status;

            return retorno;
        }

        public DefaultRetorno AutenticaTelefone(EnviarSMS obj)
        {
            var NewUrl = Globals.AlteraUserApi + "Autenticacao/AutenticaTelefone?idUsuario=" + obj.IdUsuario;

            var UserResponse = SendPost(NewUrl);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(UserResponse.Content.ToString());

            return resultado;
        }

        public DefaultRetorno AtualizaEmail(ModelAtualizaEmail obj)
        {
            //Criação Usando Monolito
            var NewUserUrl = Globals.AlteraUserApi + "AlteraUsuario/AtualizaEmail";

            var UserSerialized = JsonConvert.SerializeObject(obj);

            var UserResponse = SendPost(NewUserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(UserResponse.Content.ToString());

            return resultado;
        }

        public DefaultRetorno AtualizaTelefone(User obj)
        {
            //Criação Usando Monolito
            var NewUserUrl = Globals.AlteraUserApi + "AlteraUsuario/AtualizarTelefone";

            var UserSerialized = JsonConvert.SerializeObject(obj);

            var UserResponse = SendPost(NewUserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(UserResponse.Content.ToString());

            return resultado;
        }

        public DefaultRetorno AtualizarUsuario(User user)
        {
            var UserUrl = Globals.AlteraUserApi + "AlteraUsuario/AtualizarUsuario";

            var UserSerialized = JsonConvert.SerializeObject(user);

            var UserResponse = SendPost(UserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(UserResponse.Content.ToString());
            return resultado;

        }
        public DefaultRetorno AlterarSenha(SenhaDTO user)
        {
            var UserUrl = Globals.AlteraUserApi + "Usuario/AlterarSenha";

            var UserSerialized = JsonConvert.SerializeObject(user);

            var UserResponse = SendPost(UserUrl, UserSerialized);

            var resultado = JsonConvert.DeserializeObject<DefaultRetorno>(UserResponse.Content.ToString());
            return resultado;

        }
    }
}
