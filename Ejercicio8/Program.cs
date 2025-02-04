using System;
using System.Security.Cryptography;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
           // int años = edad(1980);
           Console.WriteLine($"La edad de la persona es: {edad(1980)}");
           Console.WriteLine($"El año de nacimiento es: {añoNacimiento(20)}");
           Console.Read();
        }
        public static int edad(int añoNacimiento)
        {
            int añoActual = DateTime.Now.Year;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        public static int añoNacimiento(int edad)
        {
            int añoActual = DateTime.Now.Year;
            int añoNacimiento = añoActual - edad;
            return añoNacimiento;
        }
    }
}
