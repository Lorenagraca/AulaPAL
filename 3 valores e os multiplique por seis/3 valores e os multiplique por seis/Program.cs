int cont = 1;
double n, mut;

while (cont <= 3)
{
    Console.WriteLine("Digite o número: ");
    n = double.Parse(Console.ReadLine());

    mut = n * 6;
    Console.WriteLine("O resultado é: " + mut);
    cont++;
}