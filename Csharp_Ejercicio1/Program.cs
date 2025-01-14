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

Console.WriteLine($"Mi array num[5] tiene {num.Length} elementos"); // Imprimir la cantidad de elementos del array.

Console.WriteLine("----------------------------------------------\n");

int[] array = new int[10]; // Declaración de un array de 10 elementos, vacio.

for(int i = 0; i < array.Length; i++)
{
    Console.Write($"Ingrese un numero a la posicion {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); // Asignación de valores al array.
}

Console.WriteLine("\n");
Console.WriteLine("Array[10] Posiciones:");

foreach(int numeros in array) // Imprimir los elementos del array.
{
    Console.WriteLine(numeros);
}

Console.WriteLine("\n");
Console.WriteLine($"Mi array tiene {array.Length} elementos"); // Imprimir la cantidad de elementos del array.

Console.ReadKey();