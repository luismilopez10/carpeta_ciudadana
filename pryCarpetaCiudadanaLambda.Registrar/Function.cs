using System.ComponentModel.DataAnnotations;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using pryCarpetaCiudadana.Registrar.Controllers;
using pryCarpetaCiudadana.Registrar.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace pryCarpetaCiudadanaLambda.Registrar
{
    public class Function
    {
        public APIGatewayProxyResponse RegistrarAsyncLambda([Required] mdlToken token, ILambdaContext context)
        {
            return new registrarController().RegistrarAsync(token).Result;
        }
    }
}
