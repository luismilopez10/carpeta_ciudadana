using Amazon.Lambda.APIGatewayEvents;
using Microsoft.AspNetCore.Mvc;
using pryCarpetaCiudadana.ValidarCliente.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.ValidarCliente.Services
{
    public class srvValidarCliente
    {
        public srvValidarCliente()
        {
        }

        public APIGatewayProxyResponse fncValidarCliente(mdlCiudadano objMdlCiudadano)
        {
            string response = String.Empty;

            string strURL = @"https://govcarpetaapp.mybluemix.net/apis/validateCitizen/";
            string strURI = strURL + objMdlCiudadano.id;

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objResponse = objHttpClient.GetAsync(strURI).Result;

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)objResponse.StatusCode,
                Body = objResponse.Content.ReadAsStringAsync().Result
            };
        }
    }
}
