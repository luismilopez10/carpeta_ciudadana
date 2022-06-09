using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pryCarpetaCiudadana.ValidarCliente.Model;
using pryCarpetaCiudadana.ValidarCliente.Services;

namespace pryCarpetaCiudadana.ValidarCliente.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class validarClienteController : ControllerBase
    {

        [HttpPost("validarCiudadano")]
        public APIGatewayProxyResponse ValidarCliente([Required] mdlCiudadano objMdlCiudadano)
        {
            srvValidarCliente objSrvValidarCliente = new srvValidarCliente();
            return objSrvValidarCliente.fncValidarCliente(objMdlCiudadano);
        }
    }
}
