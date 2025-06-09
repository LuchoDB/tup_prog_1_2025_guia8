using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Ejercicio7
    {
        static int cantidad1;
        static int cantidad2;
        static int cantidad3;
        static int cantidad4;
        static int cantidad5;
        static int numeroTransaccionMayor;
        static int contador;
        static double montoMayor;
        static double porcentajeCantidadRubro1;
        static double porcentajeCantidadRubro2;
        static double porcentajeCantidadRubro3;
        static double porcentajeCantidadRubro4;
        static double porcentajeCantidadRubro5;
        static double recaudacionTotal;

        static void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            numeroTransaccionMayor = 0;
            contador = 0;
            montoMayor = 0;
            porcentajeCantidadRubro1 = 0;
            porcentajeCantidadRubro2 = 0;
            porcentajeCantidadRubro3 = 0;
            porcentajeCantidadRubro4 = 0;
            porcentajeCantidadRubro5 = 0;
            recaudacionTotal = 0;
        }

        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto) 
        {
            switch (nroTransaccion) 
            {
                case 1:
                    contador++;
                    if (rubro>0 && rubro <= 5)
                    {
                    cantidad1 += cantidad;
                    recaudacionTotal += monto;

                    }
                    else
                    {
                        Console.WriteLine("Rubro inexistente");
                    }
                    break;
                case 2:
                    contador++;
                    
                    if (rubro > 0 && rubro <= 5)
                    {
                        
                        cantidad2 += cantidad;
                        
                        recaudacionTotal += monto;
                    }
                    else
                    {
                        Console.WriteLine("Rubro inexistente");
                    }
                    break;
                case 3:
                    contador++;
                    
                    if (rubro > 0 && rubro <= 5)
                    {
                        
                        cantidad3 += cantidad;
                        
                        recaudacionTotal += monto;
                    }
                    else
                    {
                        Console.WriteLine("Rubro inexistente");
                    }
                    break;
                case 4:
                    contador++;
                    
                    if (rubro > 0 && rubro <= 5)
                    {
                        cantidad4 += cantidad;
                       
                        recaudacionTotal += monto;
                    }
                    else
                    {
                        Console.WriteLine("Rubro inexistente");
                    }
                    break;
                case 5:
                    contador++;
                    
                    if (rubro > 0 && rubro <= 5)
                    {
                        
                        cantidad5 += cantidad;
                        
                        recaudacionTotal += monto;
                    }
                    else
                    {
                        Console.WriteLine("Rubro inexistente");
                    }

                    break;
            }
            if (monto > montoMayor)
            {
                montoMayor = monto;
                numeroTransaccionMayor = nroTransaccion;
            }
        }

        static void CalcularPorcentajesCantidadDeVentasPorRubro() 
        {
            porcentajeCantidadRubro1 = (cantidad1 * 100) / contador;
            porcentajeCantidadRubro2 = (cantidad2 * 100) / contador;
            porcentajeCantidadRubro3 = (cantidad3 * 100) / contador;
            porcentajeCantidadRubro4 = (cantidad4 * 100) / contador;
            porcentajeCantidadRubro5 = (cantidad3 * 100) / contador;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese una de las siguientes opciones\n");
            Console.WriteLine("1- Ingresar un resumen de venta");
            Console.WriteLine("2- Mostrar Numero de transaccion registrado con el mayor monto");
            Console.WriteLine("3- Mostrar porcentaje de cantidad por rubro");
            Console.WriteLine("4- Mostrar la recaudacion total");
            Console.WriteLine("(otro)- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;

        }

        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();
            Console.WriteLine("Registro de Transaccion\n");
            Console.WriteLine("Ingrese numero de transaccion");
            int transaccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese nro de Rubro");
            int Rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos vendidos");
            int cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total de la venta");
            double venta = Convert.ToDouble(Console.ReadLine());

            EvaluarTransaccionPuntoDeVenta(transaccion,Rubro,cant,venta);
            
            Console.Clear();
            Console.WriteLine("Registro Exitoso!");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            
        }

        static void MostrarPantallaPorcentajedeCantidadesPorRubro()
        {
            Console.Clear();
            CalcularPorcentajesCantidadDeVentasPorRubro();

            Console.WriteLine($"Rubro 1 - Cantidad de ventas: {cantidad1}. Porcentaje de venta: {porcentajeCantidadRubro1:F2}%");
            Console.WriteLine($"Rubro 2 - Cantidad de ventas: {cantidad2}. Porcentaje de venta: {porcentajeCantidadRubro2:F2}%");
            Console.WriteLine($"Rubro 3 - Cantidad de ventas: {cantidad3}. Porcentaje de venta: {porcentajeCantidadRubro3:F2}%");
            Console.WriteLine($"Rubro 4 - Cantidad de ventas: {cantidad4}. Porcentaje de venta: {porcentajeCantidadRubro4:F2}%");
            Console.WriteLine($"Rubro 5 - Cantidad de ventas: {cantidad5}. Porcentaje de venta: {porcentajeCantidadRubro5:F2}%");
            Console.WriteLine(" ");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            
        }

        static void MostrarPantallaTransaccionMayor()
        {
            Console.Clear();
            Console.WriteLine($"El numero de transaccion {numeroTransaccionMayor} registró el mayor monto de venta (${montoMayor})");
            Console.WriteLine("Pulse una tecla para salir");
            Console.ReadKey();
            
        }

        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();
            Console.WriteLine($"El monto total recaudado es de ${recaudacionTotal}");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayor();
                        break;
                    case 3:
                        MostrarPantallaPorcentajedeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
                    default:
                        op = 0;
                        break;
                }
                if (op != 0)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
