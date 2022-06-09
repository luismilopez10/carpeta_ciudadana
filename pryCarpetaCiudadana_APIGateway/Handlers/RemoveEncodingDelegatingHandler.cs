using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using System.Threading;

namespace pryCarpetaCiudadana_APIGateway.Handlers
{
    public class RemoveEncodingDelegatingHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.AcceptEncoding.Clear();
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
