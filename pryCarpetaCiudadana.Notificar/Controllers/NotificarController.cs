using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pryCarpetaCiudadana.Notificar.Model;

using SendGrid;
using SendGrid.Helpers.Mail;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using pryCarpetaCiudadana.Notificar.Services;

namespace pryCarpetaCiudadana.Notificar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificarController : ControllerBase
    {
        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        public async Task<string> NotificarAsync(mdlCliente objMdlCliente)
        {
            // Trae al usuario de FireBase
            //srvFirebaseConnection objConnection = new srvFirebaseConnection(Environment.GetEnvironmentVariable("FIREBASE_SECRET"), "https://carpeta-ciudadana-b6a18-default-rtdb.firebaseio.com/");
            //objConnection.fncConnection();

            // Envío de la notificación
            srvSendEmail objSendEmail = new srvSendEmail();
            string response = await objSendEmail.fncNotificar(objMdlCliente);

            return response;
        }
    }
}
