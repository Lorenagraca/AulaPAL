double q, n;

for(int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite o Numero : ");
    n = double.Parse(Console.ReadLine());

    q = Math.Pow(n, 2);

    Console.WriteLine("Este numero elevado ao quadrado é: " + q);
}
