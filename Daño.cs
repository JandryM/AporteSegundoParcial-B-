using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
     class Daño:Decorador
    {
        public Daño(BaseReparacion orden): base(orden) 
        {
            
        }
        public override string Reparar()
        {
            var repar = "El Motivo del daño es por caida";
            return base.Reparar();
        }
    }
}
