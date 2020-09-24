using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Menug
    {
        private int g = 0;

        public int LissMenu()
        {
            Console.WriteLine("  seleccione alguna opcion del menu ");

            Console.WriteLine(" \n ------------------------------ \n ");

            Console.WriteLine("1.- abrir el garage ");
            Console.WriteLine("2.- abrir a la mitad el garage ");
            Console.WriteLine("3.- cerrar el garage ");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar: ");

            g = int.Parse(Console.ReadLine());

            return g;
        }
    }
}

