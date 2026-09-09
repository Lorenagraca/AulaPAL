double cont = 0, resto, q, c,n;

while(cont <= 7)
{
    Console.WriteLine("Digite um numero: ");
    n = double.Parse(Console.ReadLine());

    resto = n % 2;

    if (resto == 0)
    {
        q = Math.Pow(n, 2);
        Console.WriteLine("Resultado: " + q);
    }
    else
    {
        c = Math.Pow(n, 3);
        Console.WriteLine("Resultado: " + c);
    }
    cont++;
}
