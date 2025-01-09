using System;

namespace Bucles
{
  class Program
  {
    static void Main(string[] args)
    {       
       // bucle for, Para i = 0, hasta 10, incrementando de 1 en 1
        for(int i = 0; i < 10; i++)
        {

          Console.WriteLine(i);
        }

      // bucle while, mientras i sea menor que 10
      int num = 1;
      while(num < 10)
      {

        Console.WriteLine(num);
        num++;

      }

      int num2 = 0;
      Console.WriteLine("\n");
      // hacer mientras, ejecuta el código al menos una vez
      do{
        Console.WriteLine(num2);
        num2++;
      } while(num2 < 10);
    
    }
  }
}