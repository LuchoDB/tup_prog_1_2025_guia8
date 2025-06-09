using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Ejercicio6
    {
        static int indecisos=0;
        static int negativos=0;
        static int positivos = 0;
        static double porcentajeIndecisos = 0;
        static double porcentajeNegativos = 0;
        static double porcentajePositivos = 0;
        static int contadorOpiniones = 0;
        static int encuestados = 0;

        static void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 1:
                    positivos++;
                    contadorOpiniones++;
                    break;
                case 2:
                    negativos++;
                    contadorOpiniones++;
                    break;
                case 3:
                    indecisos++;
                    contadorOpiniones++;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            } 
        }

        static void ProcesarEncuesta()
        {
            if (contadorOpiniones > 0)
            {
                porcentajeIndecisos = (double)indecisos/contadorOpiniones * 100;
                porcentajeNegativos = (double)negativos / contadorOpiniones * 100;
                porcentajePositivos = (double)positivos / contadorOpiniones * 100;
            }
           
        }

        static int MostrarPantallaSolicitarMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Registrar Opinion");
            Console.WriteLine("2- Procesar y mostrar resultados de encuesta");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();
            string[] preguntas = new string[3];
            preguntas[0] = "¿Que opina de tomar mate en clase?";
            preguntas[1] = "¿Que opina de faltar a misa?";
            preguntas[2] = "¿Que opina de fumar en espacios publicos cerrados?";

            Console.WriteLine("Por favor, ingrese su opinion con los siguientes valores");
            Console.WriteLine("1. Positivo");
            Console.WriteLine("2. Negativo");
            Console.WriteLine("3. Indeciso");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < preguntas.Length; i++) 
            {
                Console.WriteLine(preguntas[i]);
                    if(int.TryParse(Console.ReadLine(), out int opinion))
                    {
                        RegistrarOpinion(opinion);
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
                Console.Clear();
            }
        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            ProcesarEncuesta();
            
            if (encuestados > 0)
            {
                Console.WriteLine($"Cantidad de encuestados: {encuestados}");
                Console.WriteLine($"Porcentaje de opiniones postivas: {porcentajePositivos}");
                Console.WriteLine($"Porcentaje de opiniones negativas: {porcentajeNegativos}");
                Console.WriteLine($"Porcentaje de opiniones indecisas: {porcentajeIndecisos}");
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se realizaron encuestas");
                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarMenu();

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        encuestados++;
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
                        break;
                    default:
                        op = 0;
                        break;
                }
                if (op != 0)
                {
                    op = MostrarPantallaSolicitarMenu();
                }

            }
        }
    }
}
