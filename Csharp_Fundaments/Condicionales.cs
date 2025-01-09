using System;

namespace Condicionales
{
  class Program
  {
    static void Main(string[] args)
    {
        int num, num2;
        Console.Write("Ingrese un número: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese otro número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num > num2)
        {
            Console.WriteLine($"El numero {num} es mayor que {num2}");
        } else if (num < num2) 
        {
            Console.WriteLine($"El numero {num2} es mayor que {num}");
            // Código
        } else 
        {
          Console.WriteLine("Los números son iguales");
            // Código
        }
    }
  }
}