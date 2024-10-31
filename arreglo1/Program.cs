 void imprime(int[] lista1)
{
    foreach (int Mostrar in lista1)
    {
        Console.WriteLine(Mostrar);
    }
}

int[] lista1 = new int[1];

Random r = new Random();
for (int i = 0;i< lista1.Length; i++)
{
    lista1[i] = r.Next(1, 10 + 1);
}

imprime(lista1);

Console.Write("ingrese nuevo numero = ");
int n = int.Parse(Console.ReadLine());

Array.Resize(ref lista1, lista1.Length + 1);
lista1[lista1.Length - 1] = n;
foreach(int i in lista1)
{
    Console.WriteLine(i);

}
imprime(lista1);

