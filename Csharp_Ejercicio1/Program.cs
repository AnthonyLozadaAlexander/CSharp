// declarar un arreglo de 5 elementos de tipo entero
int[] num = new int[5];

// asignar valores a los elementos del arreglo
num[0] = 1;
num[1] = 2;
num[2] = 3;
num[3] = 4;
num[4] = 5;

Console.WriteLine($"Array num[5] Posiciones:");

// Imprimir los elementos del array.
foreach(int numeros in num)
{
  Console.WriteLine(numeros);
}

Console.WriteLine($"Mi array num[5] tiene {num.Length} elementos");

Console.ReadKey();