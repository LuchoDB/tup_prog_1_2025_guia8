using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Ejercicio2
    {
        static int edadAP;
        static int edadL;
        static int edadM;
        static int edadJ;
        static double monto;
        static double porcentajeAP;
        static double porcentajeL;
        static double porcentajeM;
        static double porcentajeJ;
        static double montoAP;
        static double montoL;
        static double montoM;
        static double montoJ;

        #region Monto A Repartir
        static void RegistrarMontoARepartir (double monto)
        {
            Ejercicio2.monto = monto; // Guardar el monto a repartir. Esta linea hace que
                                   // se pueda acceder a la variable monto desde cualquier parte de la clase.
        }
        #endregion

        #region Registrar Edad
        static void RegistrarEdad (int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 1:
                    edadAP = edad;
                    break;
                case 2:
                    edadL = edad;
                    break;
                case 3:
                    edadM = edad;
                    break;
                case 4:
                    edadJ = edad;
                    break;
            }
        }
        #endregion //esta region permite registrar la edad de cada niña según su número,

        #region Calcular Montos y Porcentajes
        static void CalcularMontosYPorcentajes()
        {
            double sumaEdad = edadAP+edadL+edadM+edadJ;
            porcentajeAP = 1.0 * edadAP / sumaEdad * 100;
            porcentajeL = 1.0 * edadL / sumaEdad * 100;
            porcentajeM = 1.0 * edadM / sumaEdad * 100;
            porcentajeJ = 1.0 * edadJ / sumaEdad * 100;
            montoAP = monto * porcentajeAP / 100;
            montoL = monto * porcentajeL / 100;
            montoM = monto * porcentajeM / 100;
            montoJ = monto * porcentajeJ / 100;
        }
        #endregion //Esta region permite calcular los montos y porcentajes correspondientes a cada niña según su edad.

        #region Menu
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una de las siguientes opciones");
            Console.WriteLine("1. Montos a Repartir");
            Console.WriteLine("2. Solicitar edad de las niñas");
            Console.WriteLine("3. Mostrar monto y porcentajes correspondientes a cada niña");                   
            Console.WriteLine("(otro). Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        #endregion //Esta region permite mostrar el menu para el usuario

        #region Solicitar Monto a Repartir
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.Write("Monto a Repartir: $");
            double monto = Convert.ToDouble(Console.ReadLine());
            RegistrarMontoARepartir(monto);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
        #endregion //Esta region permite solicitar el monto a repartir y lo guarda en la variable monto.

        #region Solicitar Edad Niña
        static void MostrarPantallaSolicitarEdadNiña()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la edad de la niña");
            for (int nro = 1; nro <= 4; nro++)
            {
                Console.Write($"Niña {nro}: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, nro);
            }
        }
        #endregion //Esta region permite solicitar la edad de cada niña y la guarda en las variables correspondientes.

        #region Mostrar Montos y Porcentajes
        static void MostrarPantallaMostrarMontosYPorcentajesPorNiña()
        {
            Console.Clear();
            Console.WriteLine("Informe de reparto de dinero:");
            CalcularMontosYPorcentajes();
            Console.WriteLine($"Niña 1: Ana Paula. Edad ({edadAP}), Porcentaje asignado ({porcentajeAP}). Monto que le corresponde {montoAP}");
            Console.WriteLine($"Niña 2: Lucía. Edad ({edadL}), Porcentaje asignado ({porcentajeL}). Monto que le corresponde {montoL}");
            Console.WriteLine($"Niña 3: Milena. Edad ({edadM}), Porcentaje asignado ({porcentajeM}). Monto que le corresponde {montoM}");
            Console.WriteLine($"Niña 4: Jazmin. Edad ({edadJ}), Porcentaje asignado ({porcentajeJ}). Monto que le corresponde {montoJ}");
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
        #endregion //Esta region permite mostrar los montos y porcentajes correspondientes a cada niña según su edad y el monto a repartir.

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarMontoARepartir();
            int op = MostrarPantallaSolicitarOpcionMenu();
            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadNiña();
                        break;
                    case 3:
                        MostrarPantallaMostrarMontosYPorcentajesPorNiña();
                        break;
                    default:
                        op = 0; //Esto es para salir del programa si se ingresa una opcion no valida
                        break;
                }
                if (op != 0) //Este if evita que se vuelva a mostrar el menu si la opcion es 0 (salir)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
                
                
            }
        }
    }
}
