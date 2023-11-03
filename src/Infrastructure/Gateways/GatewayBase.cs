using System.Net;
using RestSharp;
using static System.Net.WebRequestMethods;

namespace Infrastructure.Gateways
{
    public abstract class GatewayBase
    {
        protected GatewayBase()
        {
            Globals.Empresa3Api = "https://development-api-Empresa3.azurewebsites.net/";
            Globals.TermoUsoApi = "https://development-Empresa3-termouso.azurewebsites.net/";
            Globals.AlteraUserApi = "https://development-Empresa3-alterausuario.azurewebsites.net/";
            //Globals.AlteraUserApi = "https://localhost:44326/";
            Globals.LoginApi = "https://development-Empresa3-bff-login.azurewebsites.net/";
        }
        public static class Globals
        {
            public static String Empresa3Api;
            public static String TermoUsoApi;
            public static String AlteraUserApi;
            public static String LoginApi;
        }
        public RestResponse SendPost(string url, string serialized)
        {
          //  ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

            RestClient rest = new RestClient();
            var request = new RestRequest(url, Method.Post);
            //request.AddJsonBody(serialized,contentType: "application/json");
            request.AddParameter("application/json", serialized, ParameterType.RequestBody);

            var response = rest.Execute(request);            
            
            return response;
        }
        public RestResponse SendPost(string url)
        {
            RestClient rest = new RestClient();
            var request = new RestRequest(url, Method.Post);

            var response = rest.Execute(request);

            return response;
        }
        public string SendGet(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.ContentType = "application/json";
            request.KeepAlive = true;

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
