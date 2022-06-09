using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using pryCarpetaCiudadana.Registrar.Model;
using pryCarpetaCiudadana.Registrar.Services;

namespace pryCarpetaCiudadana.Registrar.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    [Produces("application/json")]
    public class registrarController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">El token</param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(APIGatewayProxyResponse))]
        [HttpPost("registrar")]
        public async Task<APIGatewayProxyResponse> RegistrarAsync([Required] mdlToken token)
        {
            srvRegistrar objSrvRegistrar = new srvRegistrar();
            return await objSrvRegistrar.RegistrarAsync(token);
        }

























        ///// <summary>
        ///// Registra un nuevo ciudadano
        ///// </summary>
        ///// <param name="Ciudadano"></param>
        ///// <returns></returns>
        ///// <remarks>
        ///// Sample request:
        /////     POST /registrarCiudadano
        /////     {
        /////        "id": 0,
        /////        "name": "Carlos Andres Caro",
        /////        "address": "Cra 54 # 45 -67",
        /////        "email": "caro@mymail.com",
        /////        "operatorId": 1,
        /////        "operatorName": "Operador Ciudadano"
        /////     }
        ///// </remarks>
        ///// <response code="201">Returns the newly created item</response>
        ///// <response code="400">If the item is null</response>
        //[Route("api/v1/[controller]")]
        //[HttpPost("registrarCiudadano")]
        //[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(string))]
        ////[ProducesResponseType(StatusCodes.Status400BadRequest)]
        ////[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(mdlCiudadano))]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    }
}
