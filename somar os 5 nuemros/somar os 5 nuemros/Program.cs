int cont = 1;
double n, s=0;

while (cont <= 5)
{

    Console.WriteLine("Digite um numero: ");
    n = double.Parse(Console.ReadLine());

    s = s + n;

    cont++;
}
Console.WriteLine("O resultado é: " + s);