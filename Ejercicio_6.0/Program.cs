using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una lista de numeros separados por comas: ");
            string texto = Console.ReadLine();

            if (texto == null)
            {
                Console.WriteLine("No se ingresó ningún texto.");
                return;
            }

            string[] listaNumerosTexto = texto.Split(',');
            int cantidad = listaNumerosTexto.Length; // cantidad de numeros ingresados
            int[] listaNumeros = new int[cantidad]; // lista de numeros ingresados

            for (int i = 0; i < cantidad; i++)
            {
                listaNumeros[i] = Convert.ToInt32(listaNumerosTexto[i]);
            }

            int temporal = 0;
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1; j++)
                {
                    if (listaNumeros[j] > listaNumeros[j + 1])
                    {
                        temporal = listaNumeros[j];
                        listaNumeros[j] = listaNumeros[j + 1];
                        listaNumeros[j + 1] = temporal;
                    }
                }
            }
            Console.WriteLine("Los numeros de forma ordenada ascendente son: ");
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("Los numeros de forma ordenada decendente son: ");
            for (int i = cantidad - 1; i >= 0; i--)
            {
                Console.WriteLine(listaNumeros[i]);
            }

            Console.ReadKey();

        }
    }
}