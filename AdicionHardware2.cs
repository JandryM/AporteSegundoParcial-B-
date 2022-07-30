using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
    internal class AdicionHardware2:Decorador
    {
        public AdicionHardware2(BaseReparacion orden) : base(orden)
        {

        }
        public override string Agregar()
        {
            Console.WriteLine("Se han agregado unos auriculares como Hardware adicional a la reparacion");
            var adicion = base.Agregar();
            return adicion;
        }
    }
}
