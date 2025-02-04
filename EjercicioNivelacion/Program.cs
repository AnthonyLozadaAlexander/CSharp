using System;
using System.Globalization;

namespace EjercicioNivelacion
{
  class Program
  {
    static void Main(string[] args)
    {
      string op = "si";
      bool datosIngresados = false;
      int Menu, respuesta;
      string[] Alumno = new string[5];
      double[,] Nota = new double[5, 2];

      while (op == "si")
      {
        Console.WriteLine("----Bienvenido al programa----");
        Console.WriteLine("Programa para notas de 5 alumnos");
        Console.WriteLine("Escoja una opcion del menu");
        Console.WriteLine("1: Ingresar Informacion");
        Console.WriteLine("2: Mostrar Notas Promedias");
        Console.WriteLine("3: Buscar Alumno y saber si aprobo");
        Menu = Convert.ToInt32(Console.ReadLine());

        switch (Menu)
        {

        case 1:
        if (!datosIngresados)
        {
            // Solicitar información de alumnos y notas
            // Ejemplo:
            Console.WriteLine("Ingrese la cantidad de alumnos a ingresar:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre para el alumno {i + 1}:");
                Alumno[i] = Console.ReadLine();

                Console.WriteLine($"Ingrese la primera nota para el alumno {i + 1}:");
                Nota[i, 0] = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese la segunda nota para el alumno {i + 1}:");
                Nota[i, 1] = double.Parse(Console.ReadLine());
            }

            datosIngresados = true;
        }
        else
        {
            Console.WriteLine("La información de los alumnos ya fue ingresada.");
        }
        Console.WriteLine("");
        Console.WriteLine("Desea volver al Menu Principal? si/no");
        Console.WriteLine("Ingrese si o no");

        op = Console.ReadLine();
        if(op == "si" || op == "SI" || op == "Si" || op == "sI")
        {
          op = "si";
        }
        else
        {
          Console.WriteLine("Gracias por usar el programa");
        }
        break;

        case 2:
            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine($"La nota promedio del alumno {Alumno[i]} es = {(Nota[i, 0] + Nota[i, 1]) / 2}");
            }
            Console.WriteLine("");
            Console.WriteLine("Desea volver al Menu Principal? si/no");
            Console.WriteLine("Ingrese si o no");

            op = Console.ReadLine();
            if(op == "si" || op == "SI" || op == "Si" || op == "sI")
            {
              op = "si";
            }
            else
            {
              Console.WriteLine("Gracias por usar el programa");
            }
              
            break;

        case 3:
        
            Console.WriteLine("Ingrese el numero del alumno que desea buscar");
            Console.WriteLine($"Ingrese: 1 para buscar el promedio del alumno: {Alumno[0]}");
            Console.WriteLine($"Ingrese: 2 para buscar el promedio del alumno: {Alumno[1]}");
            Console.WriteLine($"Ingrese: 3 para buscar el promedio del alumno: {Alumno[2]}");
            Console.WriteLine($"Ingrese: 4 para buscar el promedio del alumno: {Alumno[3]}");
            Console.WriteLine($"Ingrese: 5 para buscar el promedio del alumno: {Alumno[4]}");

            respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
              double promedio = (Nota[0, 0] + Nota[0, 1]) / 2;
              Console.WriteLine($"El promedio del alumno {Alumno[0]} es: {promedio} ");
            }
            else if (respuesta == 2)
            {
              double promedio = (Nota[1, 0] + Nota[1, 1]) / 2;
              Console.WriteLine($"El promedio del alumno {Alumno[1]} es: {promedio}");
            }
            else if (respuesta == 3)
            {
              double promedio = (Nota[2, 0] + Nota[2, 1]) / 2;
              Console.WriteLine($"El promedio del alumno {Alumno[2]} es: {promedio}");
            }
            else if (respuesta == 4)
            {
              double promedio = (Nota[3, 0] + Nota[3, 1]) / 2;
              Console.WriteLine($"El promedio del alumno {Alumno[3]} es: {promedio}");
            }
            else if (respuesta == 5)
            {
              double promedio = (Nota[4, 0] + Nota[4, 1]) / 2;
              Console.WriteLine($"El promedio del alumno {Alumno[4]} es: {promedio}");

            }
            else
            {
              Console.WriteLine("El numero ingresado no es valido");
            }
            break;

          default:
            Console.WriteLine("La opcion ingresada no es valida");
            break;

        }
      }
      Console.WriteLine("Desea volver al Menu Principal? si/no");
      Console.WriteLine("Ingrese si o no");

      op = Console.ReadLine();
      if(op == "si" || op == "SI" || op == "Si" || op == "sI")
      {
        op = "si";
      }
      else
      {
        Console.WriteLine("Gracias por usar el programa");
      }

    }
  }
}
