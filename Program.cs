using System;
namespace Aportee 
{
    class Program 
    {
        static void Main (string[] args) 
        {
            Console.WriteLine("*****DISPOSITIVO #1*****");
            var repardispositivo1 = new Reparacion1();
            Celular Reparacion1 = new Celular(43565737, "Iphone", "Iphone11", "Estados Unidos", "MacOS", "Grabar videos", "Mensajear");
            Reparacion1.Imprimir();
            Cliente cliente = new Cliente("Juana", "Ponce", "Celular", "Camara Dañada");
            cliente.OrdenReparar();
            var auricu = new AdicionHardware2(repardispositivo1);
            Console.WriteLine($"{auricu.Agregar()}");
            var daño = new Daño(repardispositivo1);
            Console.WriteLine($"{daño.Reparar()}");

            Console.WriteLine("\n*****DISPOSITIVO #2*****");
            var repardispositivo2 = new Reparacion2();
            Celular Reparacion2 = new Celular(560956945, "Samsung Galaxy", "Tab S", "Corea del Sur", "Android", "Wifi", "Pantalla Tactil");
            Reparacion2.Imprimir();
            Cliente client = new Cliente("Isabela", "Rivas", "Tablet", "Pantalla tactil Dañada");
            client.OrdenReparar();
            var carga = new AdicionHardware2(repardispositivo2);
            Console.WriteLine($"{auricu.Agregar()}");
            var damge = new Daño(repardispositivo2);
            Console.WriteLine($"{daño.Reparar()}");
        }
    }
}
