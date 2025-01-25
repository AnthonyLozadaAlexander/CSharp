Console.WriteLine("Programa para Realizar Operaciones Aritmeticas");
Console.WriteLine("----------------------------------------------\n");
int on, op;
double num, num2, res;

Console.Write("Ingrese el primer numero: ");
num = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
num2 = Convert.ToDouble(Console.ReadLine());

on = 1;

while (on == 1)
{
  Console.WriteLine("Ingrese la opcion que desea realizar");
  Console.WriteLine("1. Suma");
  Console.WriteLine("2. Resta");
  Console.WriteLine("3. Multiplicacion");

  op = Convert.ToInt32(Console.ReadLine());

  switch(op)
  {
    case 1:
    res = num + num2;
    Console.WriteLine($"La suma de {num} + {num2} es: {res}");
    break;
  
    case 2:
    res = num - num2;
    Console.WriteLine($"La resta de {num} - {num2} es: {res}");
    break;
  
    case 3:
    res = num * num2;
    Console.WriteLine($"La multiplicacion de {num} * {num2} es: {res}");
    break;

    default:
    Console.WriteLine("Error404, Opcion No Valida");
    break;

  }
  Console.WriteLine("----------------------------------------------\n");

  Console.WriteLine("Desea realizar otra operacion? 1 = Si, 0 = No");
  on = Convert.ToInt32(Console.ReadLine());

  if(on == 1)
  {
    Console.Write("Ingrese el primer numero: ");
    num = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el segundo numero: ");
    num2 = Convert.ToDouble(Console.ReadLine());
  }
  else if(on == 0)
  {
    Console.WriteLine("Gracias por usar el programa");
  }
  else
  {
    Console.WriteLine("Error404, Opcion No Valida");
  }

  Console.ReadLine();

}
