using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Menu
    {
    
           private int op = 0;

           public int ListaMenu()
             {

    Console.WriteLine(" Bienvenido seleccione alguna de las opciones del menu ");

    Console.WriteLine(" \n ------------------------------ \n ");

    Console.WriteLine("1.- controlar luz de sala ");
    Console.WriteLine("2.- controlar el televisor ");
    Console.WriteLine("3.- controlar el garage ");
    Console.WriteLine("4.- controlar cortina 1 ");
    Console.WriteLine("5.- controlar cortina 2 ");
    Console.WriteLine("6.- controlar luz estudio ");
    Console.WriteLine("7.- salir");

    Console.WriteLine(" \n ------------------------------- \n ");


    Console.Write("ingrese el numero de opcion que desea ejecutar: ");

    op = int.Parse(Console.ReadLine());

    return op;

}

    }
}

