using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
      class Celular: Reparacion
    {
        public Celular(int IMEI, string Marca, string Modelo, string Pais, string SistemaOperativo, string Funcionalidad1, string Funcionalidad2):base(IMEI, Marca, Modelo, Pais, SistemaOperativo, Funcionalidad1, Funcionalidad2) 
        {

        }
        public override void Imprimir()
        {
            Console.WriteLine("***Descripcion del dispositivo a Reparar***");
            Console.WriteLine(" IMEI: "+IMEI+ "\n Marca: "+Marca+ "\n Modelo: " + Modelo+ "\n Pais: " + Pais+ "\n Sistema Operativo: " + SistemaOperativo);
            
            Console.WriteLine("***Funcionalidades ***");
            Console.WriteLine("1. "+Funcionalidad1+ "\n2. " + Funcionalidad2);
        }
    }
}
