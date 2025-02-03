using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            saluda();
            despedida("Adios desde el parametro que recibe el metodo");

            Console.Read();
        }

        static public void saluda()
        {
            Console.WriteLine("Hola desde el metodo");
        }
        static public void despedida(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}