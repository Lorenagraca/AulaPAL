int cont = 1, n, t=0;
double r;

while (cont <= 20)
{
    Console.WriteLine("Digite um numero: ");
    n = int.Parse(Console.ReadLine());

    r = n % 3;
    if (r == 0)
    {
        Console.WriteLine("É multiplo de 3");
        t++;
    }
   
    cont++;

}
Console.WriteLine("Esse é o total de numeros multiplos de 3: " + t);
