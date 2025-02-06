using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar un programa que permita la carga de 15 numeros en un vector. Una vez cargados, se necesita que el programa cuente e informe por pantalla cuantas veces se repite el numero 3 en el vector.

            int[] numeros = new int[15];
            int contadorTres = 0;

            Console.WriteLine("Introduce 15 números enteros:");

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Indice[{i}]: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Datos introducidos:");
            for(int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 3)
                {
                  Console.WriteLine($"numeros[{i}] = {numeros[i]}");
                    contadorTres++;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"El número 3 se repite {contadorTres} veces en el vector.");

            Console.Read();
        }
    }
}
