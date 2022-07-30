using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
    public class Cliente
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string TipDispo { get; set; }
        string FunReparar { get; set; }
        public Cliente(string Nombre, string Apellido,string TipDispo, string FunReparar)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.TipDispo = TipDispo;
            this.FunReparar = FunReparar;
        }
        public void OrdenReparar() 
        {
            Console.WriteLine(" Nombre del cliente: "+ Nombre+ "\n Apellido del cliente: "+Apellido+ "\n Funcionalidad a Reparar: " + FunReparar+ "\n***Tipo de Dispositivo***: "+TipDispo);
        }
    }
}
