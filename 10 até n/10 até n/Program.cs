double cont=10, n, div;

Console.WriteLine("Digite um numero: ");
n = double.Parse(Console.ReadLine());

while(cont <= n)
{
    div = cont / 3;
    Console.WriteLine("Resultado: " + div);
    cont++;
}
