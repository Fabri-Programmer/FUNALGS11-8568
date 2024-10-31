using System.Collections.Generic;

int[] cambio = [5, 6, 7, 8];

foreach (int Mostrar in cambio)
{
    Console.WriteLine(Mostrar);
}

Console.WriteLine("ingrese numero a insertar = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese numero a insertar = ");
int p = int.Parse(Console.ReadLine()) -1 ;

/*
 * pedir numero y posicion
 * aumentar de tamaño de arreglo
 * desplazar numero hacia el final hasta insertar nuevo valor 
 */
Array.Resize(ref cambio, cambio.Length + 1);
for (int i = cambio.Length - 1; i > p; i--)
{
    cambio[i] = cambio[i - 1];
}
cambio[p] = n;

foreach (int Mostrar in cambio)
{
    Console.WriteLine(Mostrar);
}



