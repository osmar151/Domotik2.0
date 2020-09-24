using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class MenuLuzs
    {
        private int ops = 0;

        public int ListMenu()
        {
            Console.WriteLine("  seleccione alguna opcion del menu ");

            Console.WriteLine(" \n ------------------------------ \n ");

            Console.WriteLine("1.- encender luz de sala ");
            Console.WriteLine("2.- apagar luz de sala ");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar: ");

            ops = int.Parse(Console.ReadLine());

            return ops;
        }

    }
}
