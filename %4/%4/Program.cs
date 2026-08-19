int r, n;

for (int i = 1; i <= 10; i++)
{
  
    Console.WriteLine("Digite um numero:");
    n = int.Parse(Console.ReadLine());
    r = n;
    n = n % 4;

    if (n == 0)
    {
        Console.WriteLine(" é multiplo");
    }
}


