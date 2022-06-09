using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace pryCarpetaCiudadana.Registrar.Model
{
    public class mdlCliente
    {
        [Required]
        [Range(1000000000,9999999999, ErrorMessage = "Formato de identificación del Ciudadano no es válido, debe ser de 10 dígitos!")]
        public int id { get; set; }
        string Name;
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nombre del Ciudadano es requerida")]
        public string name {
            get { return Name; }
            set { Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower()); } 
        }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Dirección del Ciudadano es requerida")]
        public string address { get; set; }
        string Email;
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Email requerido")]
        [EmailAddress(ErrorMessage = "Formato de email del Ciudadano no es válido!")]
        public string email {
            get { return Email; }
            set { Email = name.ToLower().Split(' ')[0] + "." + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + "@carpetacolombia.co"; }
        }
        [Required]
        public int operatorId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nombre de Operador Requerido")]
        public string operatorName { get; set; }


        public mdlCliente()
        {
        }
    }
}
