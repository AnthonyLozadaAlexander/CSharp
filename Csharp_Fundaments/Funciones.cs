using System;

namespace Csharp_Fundaments
{
    internal class Funciones
    {
        public static void Main(string[] args)
        {
            // Llamamos a la función
            Saludar();
            // Llamamos a la función con parámetros
            SaludarConNombre("Juan");
            // Llamamos a la función con parámetros y retorno
            Console.WriteLine(Sumar(2, 3));
            // Llamamos a la función con parámetros y retorno
            Console.WriteLine(Multiplicar(2, 3));
            // Llamamos a la función con parámetros y retorno
            Console.WriteLine(Dividir(2, 3));
            // Llamamos a la función con parámetros y retorno
            Console.WriteLine(Restar(2, 3));
        }
        // Función sin parámetros
        public static void Saludar()
        {
            Console.WriteLine("Hola");
        }
        // Función con parámetros
        public static void SaludarConNombre(string nombre)
        {
            Console.WriteLine("Hola " + nombre);
        }
        // Función con parámetros y retorno
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        // Función con parámetros y retorno
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        // Función con parámetros y retorno
        public static int Dividir(int a, int b)
        {
            return a / b;
        }
        // Función con parámetros y retorno
        public static int Restar(int a, int b)
        {
            return a - b;
        }

    }
}
