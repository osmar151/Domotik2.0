using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domotik2._0
{
    class Program
    {

        static Casa app = new Casa();
        static Menu m = new Menu();
        static MenuLuzs ls = new MenuLuzs();
        static Menutv t = new Menutv();
        static Menug g = new Menug();
        static Mc1 c = new Mc1();
        static Mc2 l = new Mc2();
        static Mle z = new Mle();


        static void Main(string[] args)
        {
            int opciones = 0;

            //integrantes: Giuliana, Lineli, Isabel, Osmar y Fatima"
            //Link de programa de tinkercad: https://www.tinkercad.com/things/g22j7ceScJw-shiny-amur-luulia/editel?sharecode=lhL1BIAEkBAdHA1R1NFs-FRMDWA3uf6n9mpcXctal4k



            while (opciones != 6)

            {

                opciones = m.ListaMenu();

                if (opciones == 1)
                {
                    while (opciones != 2)
                    {
                        opciones = ls.ListMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("q");
                            Console.WriteLine(" luz de la sala encendida ");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine(" luz de la sala apagada");
                            app.EnviarCaracter("w");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 2)
                {
                    opciones = 0;

                    while (opciones != 2)
                    {
                        opciones = t.ListatMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine("\n");
                            app.EnviarCaracter("e");
                            Console.WriteLine("televisor encendido");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine("\n");
                            app.EnviarCaracter("r");
                            Console.WriteLine("televisor apagado");
                        }

                        Console.ReadKey();
                    }
                }


                else if (opciones == 3)

                {
                    opciones = 0;

                    while (opciones != 3)
                    {

                        opciones = g.LissMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("t");
                            Console.WriteLine("garage abierto");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("y");
                            Console.WriteLine("medio garage abierto");
                        }

                        else if (opciones == 3)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("garage cerrado");
                            app.EnviarCaracter("u");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 4)

                {
                    while (opciones != 2)
                    {
                        opciones = c.ListsMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("z");
                            Console.WriteLine("cortina 1 abierta");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("cortina 1 cerrada");
                            app.EnviarCaracter("b");
                        }



                        Console.ReadKey();
                    }
                }

                else if (opciones == 5)
                {
                    while (opciones != 2)
                    {
                        opciones = l.ListsMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("c");
                            Console.WriteLine("cortina 2 abierta");
                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("cortina 2 cerrada");
                            app.EnviarCaracter("d");
                        }

                        Console.ReadKey();
                    }
                }

                else if (opciones == 6)

                {
                    opciones = 0;

                    while (opciones != 6)

                    {
                        opciones = z.ListsMenu();

                        if (opciones == 1)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("i");
                            Console.WriteLine("intensidad 1 de la luz del estudio");

                        }

                        else if (opciones == 2)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("o");
                            Console.WriteLine("intensidad 2 de la luz del estudio");
                        }

                        else if (opciones == 3)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("p");
                            Console.WriteLine("intensidad 3 de la luz del estudio");
                        }

                        else if (opciones == 4)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("a");
                            Console.WriteLine("intensidad 4 de la luz del estudio");
                        }


                        else if (opciones == 5)
                        {
                            Console.WriteLine(" \n ");
                            app.EnviarCaracter("s");
                            Console.WriteLine("intensidad 5 de la luz del estudio");
                        }

                        else if (opciones == 6)
                        {
                            Console.WriteLine(" \n ");
                            Console.WriteLine("luz del estudio apagada");
                            app.EnviarCaracter("h");
                        }

                        Console.ReadKey();
                    }

                }

                Console.ReadKey();
            }
        }
    }
 }



