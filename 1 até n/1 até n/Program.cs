double cont = 1, n, s=0;

Console.WriteLine("Digite um numero: ");
n = double.Parse(Console.ReadLine());

while (cont <= n)
{
    s = s + cont;
    Console.WriteLine("Resultado: " + s);
    cont++;
}

