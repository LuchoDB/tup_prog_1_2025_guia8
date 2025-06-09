using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Ejercicio1
    {
#region resolución del problema
        static int acumulador = 0;
        static int contador = 0;
        static int maximo = -1;
        static int minimo = 999999;

        #region registrar valor
        static void RegistrarValor(int num)
        {
            acumulador = num;
            contador++;

            if (contador == 1 || num > maximo)
            {
                maximo = num;
            }

            if (contador == 1 || num < minimo)
            {
                minimo = num;
            }
        }
        #endregion


        #region calcular promedio
        static double CalcularPromedio()
        {
                double prom = 0;
                if (contador > 0)
                prom = 1.0*acumulador / contador;
                return prom;
                

        }
        #endregion

        #region mostrar menu
        static int MostrarPantallaSolicitarOpcion()
        {
            Console.Clear();
            Console.WriteLine("1. Procesar un solo numero");
            Console.WriteLine("2. Procesar varios numeros");
            Console.WriteLine("3. Mostrar el máximo y el minimo");
            Console.WriteLine("4. Mostrar promedio");
            Console.WriteLine("5. Mostrar cantidad de numeros ingresados");
            Console.WriteLine("6. Reiniciar variables");
            Console.WriteLine("(otro). Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        #endregion

        #region mostrar variables

        static void MostrarIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Iniciando variables");
            acumulador = 0;
            contador = 0;
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        #endregion

        #region solicitar un numero
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();

            Console.WriteLine("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(numero);

        }
        #endregion

        #region solicitar varios numeros
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese cuantos numeros va a ingresar\n\n");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            for (int i=1 ; i<=cantidad ; i++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }
        #endregion

        #region mostrar maximo y minimo
        static void MostrarPantallaMostrarMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine("Maximo y Minimo");


            Console.WriteLine($"El maximo es: {maximo}");
            Console.WriteLine($"El minimo es: {minimo}");
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        #endregion

        #region mostrar promedio

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Promedio:\n");

            if (contador > 0)
            {
                Console.WriteLine($"Promedio: {CalcularPromedio()}");
            }
            else
            {
                Console.WriteLine("No se han ingresado numeros");
            }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();

        }
        #endregion

        #region mostrar cantidad

        static void MostrarPantallaCantidad()
        {
            Console.Clear();
            Console.WriteLine("Valores procesados");
            if (contador > 0)
            {
                Console.WriteLine($"Cantidad de numeros ingresados: {contador}");
            }
            else
            {
                Console.WriteLine("No se han ingresado numeros");
            }
            Console.WriteLine("Presione una tecla para volver al menu");
            Console.ReadKey();
        }
        #endregion
#endregion
        static void Main(string[] args)
        {
            MostrarIniciarVariables();
            int op = MostrarPantallaSolicitarOpcion();
            #region iterar menu
            while (op != -1)
            {
                #region mostrar menu
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMostrarMaximoMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarIniciarVariables();
                        break;
                    default:
                        op = -1;
                        break;

                }
                #endregion

                #region pedir nueva opcion
                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcion();
                }
                #endregion
            }
            #endregion
        }
    }
}
