using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Mc2
    {
        private int r = 0;

        public int ListsMenu()
        {
            Console.WriteLine("seleccione alguna opcion del menu");

            Console.WriteLine(" \n ------------------------------ \n ");

            Console.WriteLine("1.- abrir cortina");
            Console.WriteLine("2.- cerrar cortina");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar:");

            r = int.Parse(Console.ReadLine());

            return r;
        }
    }
}

