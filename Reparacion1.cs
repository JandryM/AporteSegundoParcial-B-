using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
      class Reparacion1:BaseReparacion
    {
        public override string Agregar()
        {
            var agregar = "Adicion Agregada";
            return agregar;
        }
        public override string Reparar()
        {
            var reparar = "El dispositivo ha sido reparado";
            return reparar;
        }
    }
}
