using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
     class Decorador:BaseReparacion
    {
        protected BaseReparacion orden;
        public Decorador (BaseReparacion orden) 
        {
            this.orden = orden;
        }
        public override string Agregar()
        {
            return orden.Agregar();
        }
        public override string Reparar()
        {
            return orden.Reparar();
        }
    }
}
