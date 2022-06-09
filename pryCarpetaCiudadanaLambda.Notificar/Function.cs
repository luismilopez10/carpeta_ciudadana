using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using pryCarpetaCiudadana.Notificar.Controllers;
using pryCarpetaCiudadana.Notificar.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace pryCarpetaCiudadanaLambda.Notificar
{
    public class Function
    {
        public string NotificarAsyncLambda(mdlCliente objMdlCliente, ILambdaContext context)
        {
            string result = new NotificarController().NotificarAsync(objMdlCliente).Result;
            return result;
        }
    }
}
