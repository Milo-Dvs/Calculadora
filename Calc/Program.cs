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

                do
                {
                    Console.WriteLine("Ingresa el primer número: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out num))
                    {
                        Console.WriteLine(" ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. ");
                    }
                } while (true);

                do
                {
                    Console.WriteLine("Ingresa el segundo número: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out num2))
                    {
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. ");
                    }
                } while (true);

                switch (opcion)
                {
                    case 1:
                        resultado = num + num2;
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;

                    case 2:
                        resultado = num - num2;
                        Console.WriteLine("El resultado de la resta es: " + resultado);
                        break;

                    case 3:
                        resultado = num * num2;
                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("No se puede dividir entre cero");
                        }
                        else
                        {
                            resultado = num / num2;
                            Console.WriteLine("El resultado de la división es: " + resultado);
                        }
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != 5);

            Console.WriteLine("Programa finalizado");
        }
    }
}