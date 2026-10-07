string nome, sexo;
int cont = 1;

while (cont <= 30)
{
    Console.WriteLine("Digite o nome do funcionario: ");
    nome = Console.ReadLine();
    Console.WriteLine("Digite seu sexo M/F: ");
    sexo = Console.ReadLine();

    if ((sexo == "M") || (sexo == "m"))
    {
        Console.WriteLine(nome + "Você é do sexo masculino , precisa fazer exame");
    }
    else if ((sexo == "F") || (sexo == "f"))
    {
        Console.WriteLine(nome + "Você é do sexo feminino, não precisa fazer exame");
    }
    else
    {
        Console.WriteLine("Favor digite o sexo corretamente");
    }
    cont++;

}
