using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using pryCarpetaCiudadana.AutenticarDocumento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.AutenticarDocumento.Services
{
    public class srvAutenticarDocumento
    {
        public async Task<APIGatewayProxyResponse> fncAutenticarDocumentoAsync(mdlDocumento objMdlDocumento)
        {
            string strURL = @"https://govcarpetaapp.mybluemix.net/apis/authenticateDocument";
            string strURI = $"{strURL}/{objMdlDocumento.id.ToString()}/{objMdlDocumento.UrlDocument}/{objMdlDocumento.documentTitle}";

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objResponse = await objHttpClient.GetAsync(strURI);

            return new APIGatewayProxyResponse
            {
                StatusCode = (int)objResponse.StatusCode,
                Body = objResponse.Content.ReadAsStringAsync().Result
            };
        }
    }
}
