Console.WriteLine("Crea un programa en C# que solicite un numero entero x al usuario y imprima el resultado de la siguientes operaciones\n");
double x,y,res1, res2, res3, res4, promedio;
Console.Write("Ingrese el primer numero en x: ");
x = Convert.ToDouble(Console.ReadLine());

res1 = (-6 + x * 5);
res2 = (13 - 2) * x;
res3 = (x + -2) * (20/10);
res4 = (12 + x) / (5 - 4);

Console.WriteLine("La primera respuesta es: " + res1);
Console.WriteLine("La segunda respuesta es: " + res2);
Console.WriteLine("La tercera respuesta es: " + res3);
Console.WriteLine("La cuarta respuesta es: " + res4);

Console.WriteLine("-------------------------------------------------------------");

Double z, w;
Console.WriteLine("Escribe un programa en C# que calcule la media aritmetica de 4 factores introducidos por el usuario, uno por cada linea\n");
Console.Write("Introduce el primer numero: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el segundo numero: ");
y = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el tercer numero: ");
z = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el cuarto numero: ");
w = Convert.ToDouble(Console.ReadLine());

promedio = (x + y + z + w) / 4;

Console.WriteLine($"La media aritmetica es: {promedio}");


Console.WriteLine("-------------------------------------------------------------\n");

Console.WriteLine("Escribe un programa en C# que solicite al usuario tres numeros (a,b,c) y muestre el resultado de (a+b)*c y el resultado a*c + b*c\n");
double a, b, c, res5, res6;

Console.Write("Introduce el primer numero: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Introduce el segundo numero: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("Introduce el tercer numero: ");
c = Convert.ToDouble(Console.ReadLine());

res5 = (a + b) * c;
res6 = a * c + b * c;
Console.WriteLine("\n");

Console.WriteLine("El resultado de (a+b)*c es: " + res5);
Console.WriteLine("El resultado de a*c + b*c es: " + res6);

Console.WriteLine("-------------------------------------------------------------\n");

Console.WriteLine("Escribe un programa en C# que solicite al usuario un 2 numeros enteros para mostrar la funcion");
Console.Write("Introduce el primer numero: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Introduce el segundo numero: ");
int x2 = Convert.ToInt32(Console.ReadLine());

for (int i = x1; i <= x2; i++)
{
    int resultado = i * i - 2 * i + 1;
    Console.WriteLine(" {0} ",resultado);
}

Console.ReadKey();
