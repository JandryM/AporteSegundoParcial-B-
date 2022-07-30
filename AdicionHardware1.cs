using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
    internal class AdicionHardware1:Decorador
    {
        public AdicionHardware1(BaseReparacion orden): base(orden) 
        {

        }
        public override string Agregar()
        {
            Console.WriteLine("Se ha agregado un cargador como Hardware adicional a la reparacion");
            var adicion = base.Agregar();
            return adicion;
        }
    }
}
