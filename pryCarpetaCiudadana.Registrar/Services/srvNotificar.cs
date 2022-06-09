using Newtonsoft.Json;
using pryCarpetaCiudadana.Registrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Registrar.Services
{
    public class srvNotificar
    {        
        public srvNotificar()
        {
        }
        public async Task<string> fncNotificar(mdlCliente objMdlCliente)
        {
            mdlClienteNotificar objNuevoCliente = new mdlClienteNotificar();
            objNuevoCliente.id = objMdlCliente.id;
            objNuevoCliente.name = objMdlCliente.name;
            objNuevoCliente.operatorName= objMdlCliente.operatorName;

            var json = JsonConvert.SerializeObject(objNuevoCliente);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            string strURL = @"https://a8lx01v1mb.execute-api.us-east-1.amazonaws.com/prod/v1/notificar";
            string strURI = strURL;

            HttpClient objHttpClient = new HttpClient();
            HttpResponseMessage objResponse = await objHttpClient.PostAsync(strURI, content);

            return objResponse.Content.ReadAsStringAsync().Result;
        }
    }
}
