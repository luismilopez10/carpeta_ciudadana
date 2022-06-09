using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using pryCarpetaCiudadana.AutenticarDocumento.Controllers;
using pryCarpetaCiudadana.AutenticarDocumento.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace pryCarpetaCiudadana.AuthDoc
{
    public class Function
    {
        public async Task<APIGatewayProxyResponse> AuthDocAsyncLambda(mdlDocumento objMdlDocumento, ILambdaContext context)
        {
            AutenticarDocumentoController objAutenticarDocumentoController = new AutenticarDocumentoController();
            return await objAutenticarDocumentoController.AutenticarDocumento(objMdlDocumento);
        }
    }
}
