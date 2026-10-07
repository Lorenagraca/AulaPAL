string[] j = new string[11];
int p;

for (int i =0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine("Digite o " + p + "° nome: ");
    j[i] = Console.ReadLine();
}
for (int i = 0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine("O nome do jogador armazenado na posição " + p + "° do vetor =" + j[i]);
}