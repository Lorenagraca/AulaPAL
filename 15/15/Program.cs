double n, r, qt=0;

for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um numero:");
    n = int.Parse(Console.ReadLine());
    r = n;
    n = n % 2;

    if (n == 0)
    {
        Console.WriteLine("Esse numero é par");
    qt++;
    }
}
Console.WriteLine("quantidade total de números pares: " + qt);
