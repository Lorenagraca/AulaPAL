double al, qtd = 0;
string sx;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("Digite sua altura: ");
    al = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite seu sexo: ");
    sx = Console.ReadLine();

    if ((sx == "M" || sx == "m"))
    {
        qtd++;
    }
    else if ((sx == "F" || sx == "f"))
    {
        Console.WriteLine("A altura do sexo femenino é: " + al);
    }
        
}
Console.WriteLine("A quantidade de Homens é: " + qtd);