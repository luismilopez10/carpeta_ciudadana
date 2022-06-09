using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace pryCarpetaCiudadana.Notificar.Model
{
    public class mdlCliente
    {
        public int id { get; set; }
        public string name { get; set; }
        public string operatorName { get; set; }


        public mdlCliente()
        {
        }
    }
}
