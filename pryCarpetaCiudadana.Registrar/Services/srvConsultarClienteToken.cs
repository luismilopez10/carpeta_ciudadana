using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pryCarpetaCiudadana.Registrar.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Registrar.Services
{
    public class srvConsultarClienteToken
    {
        public async Task<mdlCliente> fncConsultarClienteToken(mdlToken token)
        {
            // https://stackoverflow.com/questions/38340078/how-to-decode-jwt-token

            var stream = token.token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = jsonToken as JwtSecurityToken;

            string userId = tokenS.Claims.First(claim => claim.Type == "user_id").Value;

            string strURL = @"https://a8lx01v1mb.execute-api.us-east-1.amazonaws.com/prod/v1/users/";
            string strURI = strURL + userId;

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objResponse = await objHttpClient.GetAsync(strURI);

            mdlClienteConsultarBD objMdlClienteConsultarBD = JsonConvert.DeserializeObject<mdlClienteConsultarBD>(objResponse.Content.ReadAsStringAsync().Result);

            mdlCliente nuevoCliente = new mdlCliente
            {
                id = objMdlClienteConsultarBD.docId,
                name = objMdlClienteConsultarBD.nombre,
                address = objMdlClienteConsultarBD.direccion,
                email = objMdlClienteConsultarBD.email,
                operatorId = objMdlClienteConsultarBD.operadorId,
                operatorName = objMdlClienteConsultarBD.operadorName
                //id = 1222567890,
                //name = "abc",
                //address = "def",
                //email = "ghi@jk.com",
                //operatorId = 1,
                //operatorName = "XZ"
            };

            return nuevoCliente;
        }
    }
}
