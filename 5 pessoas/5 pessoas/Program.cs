double id, an, aa;
int cont = 1;

while (cont <= 5)
{
    Console.WriteLine("Digite o ano atual: ");
    aa = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o seu ano de nacimento: ");
    an = double.Parse(Console.ReadLine());

    id = aa - an;

    Console.WriteLine("Sua idade é: " + id);

    cont++;

}