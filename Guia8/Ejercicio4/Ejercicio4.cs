using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Ejercicio4
    {
        static string jugador1;
        static int setGanados1;
        static string jugador2;
        static int setGanados2;

        static void RegistrarJugadores(string nombre1,string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
            setGanados1 = 0;
            setGanados2 = 0;
        }

        static void RegistrarResultdosSet(int resultado1, int resultado2)
        {
            setGanados1 += resultado1;
            setGanados2 += resultado2;
        }

        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                return jugador1;
            }
            else if (setGanados2 > setGanados1)
            {
                return jugador2;
            }
            else
            {
                return "Empate";
            }
        }

        static int PantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Registrar los nombres de los dos jugadores");
            Console.WriteLine("2- Registrar los resultados de cada set de los jugadores");
            Console.WriteLine("3- Mostrar al ganador");
            Console.WriteLine("(otro)- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del jugador 1:");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2:");
            string nombre2 = Console.ReadLine();
            RegistrarJugadores(nombre1, nombre2);
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarResultadosSet()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el resultado del set para el jugador 1:");
            int resultado1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el resultado del set para el jugador 2:");
            int resultado2 = Convert.ToInt32(Console.ReadLine());
            RegistrarResultdosSet(resultado1, resultado2);
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaGanador()
        {
            Console.Clear();
            string ganador = DeterminarGanador();
            if (ganador == "Empate")
            {
                Console.WriteLine("El partido ha terminado en empate.");
            }
            else
            {
                Console.WriteLine($"El ganador es: {ganador}");
            }
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int opcion = PantallaSolicitarOpcionMenu();
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadosSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
                        break;
                    default:
                        opcion = 0;
                        break;
                }
                if (opcion != 0)
                {
                    opcion = PantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
