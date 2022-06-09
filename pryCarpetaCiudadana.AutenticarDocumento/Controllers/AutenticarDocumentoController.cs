using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pryCarpetaCiudadana.AutenticarDocumento.Model;
using pryCarpetaCiudadana.AutenticarDocumento.Services;

namespace pryCarpetaCiudadana.AutenticarDocumento.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class AutenticarDocumentoController : ControllerBase
    {
        [HttpPost("autenticarDocumento")]
        public async Task<APIGatewayProxyResponse> AutenticarDocumento(mdlDocumento objMdlDocumento)
        {
            srvAutenticarDocumento objSrvAutenticarDocumento = new srvAutenticarDocumento();
            return await objSrvAutenticarDocumento.fncAutenticarDocumentoAsync(objMdlDocumento);
        }
    }
}
