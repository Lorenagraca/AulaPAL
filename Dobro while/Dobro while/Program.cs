int cont = 0, n;
double d;

Console.WriteLine("Digite um número: ");
n = int.Parse(Console.ReadLine());

while (cont <= n)
{
    d = cont * 2;
    Console.WriteLine(cont + " * 2= " + d);
    cont++;
}
