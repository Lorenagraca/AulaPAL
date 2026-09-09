double Na, Nb, M, cont = 1;
string n;

while(cont <= 5)
{
    Console.WriteLine("Digite seu nome: ");
    n = Console.ReadLine();
    Console.WriteLine("Digite a nota A: ");
    Na = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota B: ");
    Nb = double.Parse(Console.ReadLine());

    M = (Na + Nb) / 2;
    Console.WriteLine("A sua Média é: " + M);
    cont++;
}