using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Ejercicio5
    {
        #region Determinar Dias
        static int DeterminarLosDiasDelMes(int mes, int año)

        {
            int dias;
            bool paridad = (mes % 2 == 0);
            bool primeraMitad = mes <= 6;

            if (primeraMitad)
            {
                //Verifico si esta en la primera mitad del año
                if (paridad)
                {
                    if (mes == 2)
                    {
                        if (DeterminarSiEsBisiesto(año))
                        {
                            dias = 29;
                        }
                        else
                        {
                            dias = 28;
                        }
                    }
                    else
                    {
                        return 30;
                    }
                }
                else
                {
                    return 30;
                }

            }
            else
            {
                if (paridad)
                {
                    dias = 31;
                }
                else
                {
                    dias = 30;
                }
            }
            return dias;

        }
        #endregion

        #region Determinar si es bisiesto
        static bool DeterminarSiEsBisiesto (int años)
        {
            bool Bisiesto = false;
            if (años % 4 == 0)
            {
                if (años % 100 == 0)
                {
                    if (años % 400 == 0)
                    {
                        Bisiesto = true;
                    }
                }
                else
                {
                    Bisiesto = true;
                }
            }
            return Bisiesto;
        }
        #endregion

        #region Menu
        static int MostrarOpcionesMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Determinar la cantidad de dias que tiene el mes");
            Console.WriteLine("2. Verificar si un año es bisiesto");
            Console.WriteLine("(otro). Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region Pantalla de solicitud
        static void MostrarPantallaSolicitarMesYAño()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el mes (1-12):");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año:");
            int año = Convert.ToInt32(Console.ReadLine());
            int dias = DeterminarLosDiasDelMes(mes, año);
            Console.WriteLine($"El mes {mes} del año {año} tiene {dias} días.");
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }
        #endregion

        #region Verificacion Bisiesto
        static void MostrarPantallaVerificarBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año a verificar si es bisiesto:");
            int año = Convert.ToInt32(Console.ReadLine());
            if (DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }
        #endregion
        static void Main(string[] args)
        {
            int opcion = MostrarOpcionesMenu();
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarMesYAño();
                        break;
                    case 2:
                        MostrarPantallaVerificarBisiesto();
                        break;
                    default:
                        opcion = 0;
                        break;
                }
                if (opcion != 0) // Esto es para que el programa no se cierre inmediatamente después de mostrar los resultados.
                {
                    opcion = MostrarOpcionesMenu();
                }
            }
        }
    }
}
