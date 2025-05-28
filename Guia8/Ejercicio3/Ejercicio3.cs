using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Ejercicio3
    {
        static string nombre1;
        static string nombre2;
        static string nombre3;
        static int libreta1;
        static int libreta2;
        static int libreta3;
        static int orden = 0; //Orden en que se ingresan

        #region Registro de nombres y libretas
        static void RegistrarNombreYNumeroDeLibreta(string nombre, int numeroLibreta)
        {
            if (orden == 0)
            {
                nombre1 = nombre;
                libreta1 = numeroLibreta;
            }
            else if (orden == 1)
            {
                if (numeroLibreta < libreta1)
                {
                    nombre2 = nombre1;
                    libreta2 = libreta1;
                    nombre1 = nombre;
                    libreta1 = numeroLibreta;
                }
                else
                {
                    nombre2 = nombre;
                    libreta2 = numeroLibreta;
                }
            }
            else if (orden == 2)
            {
                if (numeroLibreta < libreta1)
                {
                    nombre3 = nombre2;
                    libreta3 = libreta2;
                    nombre2 = nombre1;
                    libreta2 = libreta1;
                    nombre1 = nombre;
                    libreta1 = numeroLibreta;
                }
                if (numeroLibreta < libreta2)
                {
                    nombre3 = nombre2;
                    libreta3 = libreta2;
                    nombre2 = nombre;
                    libreta2 = numeroLibreta;
                }
                else
                {
                    nombre3 = nombre;
                    libreta3 = numeroLibreta;
                }

            }
            orden++;
        }
        #endregion //Esta region permite registrar el nombre y número de libreta de cada alumno ingresado, hasta un máximo de 3 alumnos.

        #region Menu

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una opcion:");
            Console.WriteLine("1. Registrar nombre y número de libreta");
            Console.WriteLine("2. Mostrar lista ordenada");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region Solicitar Alumnos
        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            for (int i = 1 ; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese el {i}° alumno");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese el número de libreta del alumno {i}");
                int numeroLibreta = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroDeLibreta(nombre, numeroLibreta);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        #endregion

        #region Mostrar Lista Ordenada
        static void MostrarPantallaListaOrdenada()
        {
            Console.Clear();
            if (orden == 0)
            {
                Console.WriteLine("No se han ingresado alumnos.");
            }
            else
            {
                Console.WriteLine("Lista de alumnos ordenada por número de libreta:");
                if (orden >= 0) Console.WriteLine($"{libreta1} - {nombre1}");
                if (orden >= 1) Console.WriteLine($"{libreta2} - {nombre2}");
                if (orden >= 2) Console.WriteLine($"{libreta3} - {nombre3}");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        #endregion //Esta region permite mostrar la lista de alumnos ordenada por número de libreta, mostrando hasta 3 alumnos.
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        orden++;
                        break;
                    case 2:
                        MostrarPantallaListaOrdenada();
                        break;
                    default:
                        opcion = 0;
                        break;
                }
                if (opcion != 0) // Esto es para que el programa no se cierre inmediatamente después de mostrar la lista ordenada o solicitar alumnos.
                {
                    opcion = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
