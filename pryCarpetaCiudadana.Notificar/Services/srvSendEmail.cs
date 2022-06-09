using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SendGrid;
using SendGrid.Helpers.Mail;
using pryCarpetaCiudadana.Notificar.Model;

namespace pryCarpetaCiudadana.Notificar.Services
{
    public class srvSendEmail
    {
        private object objMdlEmail;

        public async Task<string> fncNotificar(mdlCliente objMdlCliente)
        {
            // Envío de la notificación
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress
            {
                Name = "Carpeta Ciudadana",
                Email = "luis.miguel.lopez.10@gmail.com"
            };
            var to = new EmailAddress
            {
                Name = "Registraduría",
                Email = "luis.miguel.lopez.10@gmail.com"
            };
            var subject = "Registro de nuevo ciudadano";
            var plainTextContext = $"El ciudadano {objMdlCliente.name} con número de identificación: {objMdlCliente.id} ahora se encuentra registrado en el operador: {objMdlCliente.operatorName}.";
            var htmlContent = $"<strong>{plainTextContext}</strong>";

            var msg = MailHelper.CreateSingleEmail(
                from,
                to,
                subject,
                plainTextContext,
                htmlContent
                );

            var response = await client.SendEmailAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                return "Notificación enviada con éxito";
            }

            return "Ocurrió un error al intentar enviar la notificación";
        }
    }
}
