using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Notificar.Model
{
    public class mdlEmail
    {
        [Required]
        public EmailAddress to { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string plainTextContext { get; set; }
    }
}
