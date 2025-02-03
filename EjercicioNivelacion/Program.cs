using System;
using System.Globalization;

namespace EjercicioNivelacion
{
  class Program
  {
    static void main(string[] args)
    {
      string op = "si";
      int Menu, respuesta;
      string[] Alumno = new string[5];
      double[,] Nota = new double[5, 2];

      while (op == "si")
      {
        Console.WriteLine("Programa para notas de 5 alumnos");
        Console.WriteLine("Escoja una opcion del menu");
        Console.WriteLine("1: Ingresar Informacion");
        Console.WriteLine("2: Mostrar Notas Promedias");
        Console.WriteLine("3: Buscar Alumno y saber si aprobo");
        Menu = Convert.ToInt32(Console.ReadLine());

        switch (Menu)
        {
          case 1:

            for (int i = 0; i < 5; i++)
            {
              Console.WriteLine($"Ingrese el nombre del alumno# {i + 1}");
              Alumno[i] = Console.ReadLine();
              for (int j = 0; j < 2; j++)
              {
                if (j == 0)
                {
                  Console.WriteLine("Ingrese la nota del primer parcial");
                  Nota[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                  Console.WriteLine("Ingrese la nota del segundo parcial");
                  Nota[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("La nota de los 5 alumnos fue ingresada correctamente");
              }
            }
            break;

            case 2:
            for(int i = 0; i < 5; i++)
            {
               Console.WriteLine($"La nota promedio del alumno {Alumno[i]} es = {(Nota[i,0]+Nota[i,1])/2}"); 
            }
            break;
        }
      }

    }
  }
}
