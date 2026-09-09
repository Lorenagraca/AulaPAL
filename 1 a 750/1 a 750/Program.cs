int cont = 1, r=0, t=0;

while (cont <= 750)
{
    Console.WriteLine(cont);
    cont++;
    r = cont % 4;
    if (r == 0)
    {
        Console.WriteLine("É multiplo de 4");
        t++;
    }

    cont++;

}
Console.WriteLine("Esse é o total de numeros multiplos de 4: " + t);