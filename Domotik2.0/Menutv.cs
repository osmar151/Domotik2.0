using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Menutv
    {
        private int om = 0;

        public int ListatMenu()
        {
            Console.WriteLine("  seleccione alguna opcion del menu ");

            Console.WriteLine(" \n ------------------------------ \n ");

            Console.WriteLine("1.- encender televisor ");
            Console.WriteLine("2.- apagar televisor ");
            Console.WriteLine(" \n ------------------------------- \n ");


            Console.Write("ingrese el numero de opcion que desea ejecutar: ");

            om = int.Parse(Console.ReadLine());

            return om;
        }

    }
}

