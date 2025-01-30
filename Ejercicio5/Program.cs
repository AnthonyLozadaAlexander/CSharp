Console.WriteLine("Ejercicio: Ordenar un array");
Console.WriteLine("--------------------------------");
int[] numeros = { 4, 3, 7, 10, 1, 5, 7 };
Array.Sort(numeros);

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Indice [{i}] = {numeros[i]}");
}

Console.WriteLine("--------------------------------");
Console.WriteLine("Ejercicio: Mostrar el mayor y menor de un array");

int[] valores = { 4, 3, 7, 10, 1, 5, 7 };

int mayor = valores[0];
int menor = valores[0];

Console.WriteLine("Los valores del array son: ");
for(int i = 0; i < valores.Length; i ++)
{
    Console.WriteLine($"Indice [{i}] = {valores[i]}");
}

for (int i = 1; i < valores.Length; i++)
{
    if (valores[i] > mayor)
    {
        mayor = valores[i];
    }
    if (valores[i] < menor)
    {
        menor = valores[i];
    }
}
Console.WriteLine("--------------------------------");
Console.WriteLine($"El mayor es: {mayor}");
Console.WriteLine($"EL menor es: {menor}");

Console.ReadKey();