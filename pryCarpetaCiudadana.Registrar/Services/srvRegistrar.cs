using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using pryCarpetaCiudadana.Registrar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Registrar.Services
{
    public class srvRegistrar
    {
        public async Task<APIGatewayProxyResponse> RegistrarAsync([Required] mdlToken token)
        {
            string response;

            srvConsultarClienteToken objSrvConsultarClienteToken = new srvConsultarClienteToken();
            mdlCliente nuevoCliente = await objSrvConsultarClienteToken.fncConsultarClienteToken(token);

            var json = JsonConvert.SerializeObject(nuevoCliente);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            string strURL = @"https://govcarpetaapp.mybluemix.net/apis/registerCitizen/";
            string strURI = strURL;

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objResponse = await objHttpClient.PostAsync(strURI, content);


            if (objResponse.StatusCode == HttpStatusCode.NotImplemented)
            {
                response = $"Error al crear Ciudadano con id: {nuevoCliente.id}";
            }
            else
            {
                response = objResponse.Content.ReadAsStringAsync().Result;

                srvNotificar objSrvNotificar = new srvNotificar();
                _ = await objSrvNotificar.fncNotificar(nuevoCliente);
            }

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)objResponse.StatusCode,
                Body = objResponse.Content.ReadAsStringAsync().Result
            };
        }
    }
}
