Console.WriteLine("Ejercicio: Genera dos arrays con valores aleatorios e indica cuales coindicen");
Console.WriteLine("-----------------------------------------------------------------------------");

Random r = new Random(); // Generador de numeros aleatorios
int longitud = 10;
int numeroCoincidencias = 0;
int[] array1 = new int[longitud];
int[] array2 = new int[longitud];
int[] arrayCoincidencias = new int[longitud];

Console.WriteLine("Array 1");
for(int i = 0; i < array1.Length; i++)
{
  array1[i] = r.Next(1, 50); // entre 1 a 50
  Console.WriteLine(array1[i]);
}

Console.WriteLine("Array 2");
for(int i = 0; i < array2.Length; i++)
{
  array2[i] = r.Next(1, 50); // entre 1 a 50
  Console.WriteLine(array2[i]);
}

//? Verificar si hay coincidencias
for(int i = 0; i < array1.Length; i++)
{
  for(int j = 0; j < array2.Length; j++)
  {
    if(array1[i] == array2[j])
    {
      bool exits = false;
      for(int z = 0; z < numeroCoincidencias; z++)
      {
        if(arrayCoincidencias[z] == array1[i])
        {
          exits = true;
        }
      }
      if(!exits)
      {
        arrayCoincidencias[numeroCoincidencias] = array1[i];
        numeroCoincidencias++;
      }
    }
  }
}

//? Mostrar/Imprimir las coincidencias
Console.WriteLine("Las Coincidencias son: ");
for(int i = 0; i < numeroCoincidencias; i++)
{
  Console.WriteLine(arrayCoincidencias[i]);
}

if(numeroCoincidencias >= 3)
{
  Console.WriteLine("Felicidades!, Has acertado 3 numeros");
}
else
{
  Console.WriteLine("Necesitas acertar 3 numeros para ganar");
} 

Console.ReadKey();