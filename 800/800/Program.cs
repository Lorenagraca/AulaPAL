int cont = 800; 
float sP = 0;

while (cont >= 0)
{

    if (cont % 2 != 0)
    {
        Console.WriteLine(cont);
    }
    else
    {
        sP += cont;
    }

    cont--;
}

Console.WriteLine($"resultado: {sP}");