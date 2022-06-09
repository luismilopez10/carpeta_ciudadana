using Amazon.Lambda.AspNetCoreServer;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Registrar
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            //base.Init(builder);)

            builder

                .UseKestrel(c => c.AddServerHeader = false)
                .UseStartup<Startup>();
        }
        //pryCarpetaCiudadana.Registrar::pryCarpetaCiudadana.Registrar.LambdaEntryPoint::FunctionHandlerAsync
    }
}
