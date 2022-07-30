using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aportee
{
     abstract class Reparacion
    {
        public int IMEI { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Pais { get; set; }
        public string SistemaOperativo { get; set; }
        public string Funcionalidad1 { get; set; }
        public string Funcionalidad2 { get; set; }
        public Reparacion(int IMEI, string Marca, string Modelo,string Pais, string SistemaOperativo,string Funcionalidad1, string Funcionalidad2)
        {
            this.IMEI = IMEI;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Pais = Pais;
            this.SistemaOperativo = SistemaOperativo;
            this.Funcionalidad1 = Funcionalidad1;
            this.Funcionalidad2 = Funcionalidad2;
        }
        public abstract void Imprimir();
        
    }
}

