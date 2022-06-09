using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pryCarpetaCiudadana.Registrar.Model
{
    public class mdlClienteConsultarBD
    {
        public string Id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int operadorId { get; set; }
        public string operadorName { get; set; }
        public int docId { get; set; }
    }
}
