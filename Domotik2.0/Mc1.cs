using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Mc1
    {
       private int s = 0;

        public int ListsMenu()
        {
            Console.WriteLine("seleccione alguna opcion del menu");

            Console.WriteLine(" \n ------------------------------ \n ");

            Console.WriteLine("1.- abrir cortina 1");
            Console.WriteLine("2.- cerrar cortina 1");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar:");

            s = int.Parse(Console.ReadLine());

            return s;
        }
    }
}
