using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Microsoft.AspNetCore.Mvc;
using pryCarpetaCiudadana.ValidarCliente.Controllers;
using pryCarpetaCiudadana.ValidarCliente.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace pryCarpetaCiudadanaLambda.ValidarCliente
{
    public class Function
    {
        public APIGatewayProxyResponse ValidarCiudadanoLambda([Required] mdlCiudadano objMdlCiudadano, ILambdaContext context)
        {
            validarClienteController objValidarClienteController = new validarClienteController();

            return objValidarClienteController.ValidarCliente(objMdlCiudadano);
        }
    }
}
