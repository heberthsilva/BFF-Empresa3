using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class DefaultRetornoUser
    {
        public string Mensagem { get; set; }
        public string MensagemLog { get; set; }
        public string MensagemStatus { get; set; }
        public int Status { get; set; }
        public List<User.User> ListaObjeto { get; set; } = new List<User.User>();
    }

    public class DefaultRetornoUserMarkII
    {
        public string Mensagem { get; set; }
        public string MensagemLog { get; set; }
        public string MensagemStatus { get; set; }
        public int Status { get; set; }
        public List<User.UserMarkII> ListaObjeto { get; set; } = new List<User.UserMarkII>();
    }

}
