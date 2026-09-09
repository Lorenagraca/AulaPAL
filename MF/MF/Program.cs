int cont = 1;
string n, sx;

while (cont <= 15)
{
    Console.WriteLine("Digite o seu nome: ");
    n = Console.ReadLine();
    Console.WriteLine("Digite o seu sexo (M/F): ");
    sx = Console.ReadLine().ToUpper();

    if (sx == "M")
    {
        Console.WriteLine("Você precisa fazer o exame");
    }

    else if (sx == "F")
    {
        Console.WriteLine("Você não precisa fazer o exame");
    }
    else
    {
        Console.WriteLine("Erro!");
    }
    cont++;
}
