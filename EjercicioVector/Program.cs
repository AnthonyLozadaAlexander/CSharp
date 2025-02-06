using System;

namespace EjercicioVector
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Realizar un programa que permita la carga de 15 numeros en un vector. Una vez cargados, se necesita que el programa cuente e informe por pantalla cuantas veces se repite el numero 3 en el vector.
            
            int[] nums = new int[15];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"Ingrese un numero al Indice[{i}] = ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("Datos: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }

            int count = 0;
            Console.WriteLine("");
            Console.WriteLine("Datos con el numero 3 repetido: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    Console.WriteLine($"nums[{i}] = {nums[i]}");
                    count = count + 1;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"El numero 3 se repitio: {count} veces");

            Console.Read();
        }

    }
}

