using System;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esNum;
            byte opcion = 0;
            int num, num2;
            int resultado;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elige una opción: ");

                do
                {
                    string input = Console.ReadLine();

                    if (byte.TryParse(input, out opcion) && opcion >= 1 && opcion <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. ");
                    }
                } while (true);

                if (opcion == 5)
                {
                    break;
                }



            } while (opcion != 5);

            Console.WriteLine("Programa finalizado");
        }
    }
}