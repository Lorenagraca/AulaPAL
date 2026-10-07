double cont = 1,n;
while(cont <= 22)
{
    Console.WriteLine("Digite um numero: ");
    n = double.Parse(Console.ReadLine());

    if (n > 0)
    {
        Console.WriteLine("este numero é maior que zero");
    }
    else if(n == 0)
    {
        Console.WriteLine("este numero é igual a zero");
    }
    else
    {
        Console.WriteLine("este numero é menor que zero");
    }
    cont++;
}
