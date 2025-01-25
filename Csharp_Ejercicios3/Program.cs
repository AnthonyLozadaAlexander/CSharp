Console.WriteLine("Ejercicio_3");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Programa que imprime los numeros pares del 0 al 100\n");

int num;

for(int i = 0; i <= 100; i++)
{
    num = i;
    if (num % 2 == 0)
    {
        Console.WriteLine($"{i} es un numero par");
    }
}

Console.ReadKey();