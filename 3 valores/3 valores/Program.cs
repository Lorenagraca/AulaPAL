double n, m;
int cont = 1;

while (cont <= 3)
{
    Console.WriteLine("Digite um número: ");
    n = double.Parse(Console.ReadLine());
    m = n * 7;
    Console.WriteLine("Resulatado: " + m);
    cont++;
}
