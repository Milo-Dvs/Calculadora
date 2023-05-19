using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion = 0;
            int num, num2;
            int resultado;
            do
            {
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.WriteLine("Elige una opción: ");

                opcion = validacionNumerica(1, 5);
                Console.WriteLine(opcion);
                if (opcion == 5)
                {
                    break;
                }

                Console.Write("Ingrese el primer número: ");
                num = validacion2(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                num2 = validacion2(Console.ReadLine());

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


            static byte validacionNumerica(byte min, byte max)
            {
                byte num;

                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Ingresa un número entre {min} y {max}: ");


                    try
                    {
                        num = byte.Parse(Console.ReadLine());

                        if (num < min || num > max)
                        {
                            throw new ArgumentOutOfRangeException();
                        }

                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: debes ingresar un número entero ");
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine($"Error: debes ingresar un número entre {min} y {max}.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine($"Error: debes ingresar un número entre {min} y {max}.");
                    }

                }

                return num;
            }


            static int validacion2(string entrada)
            {
                bool bandera = true;
                int num;
                while (bandera)
                {
                    if (int.TryParse(entrada, out num))
                    {

                        bandera = false;
                        return num;
                    }
                    else
                    {
                        Console.WriteLine("INGRESE UN NÚMERO VÁLIDO");
                    }
                }
                return 0;
            }
        }
    }
}