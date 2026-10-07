string[] c = new string[15];
int p;

for (int i = 0; i < 15; i++)
{
    p = i + 1;
    Console.WriteLine("Digite o " + p + "° nome: ");
    c[i] = Console.ReadLine();
}
for (int i = 0; i < 11; i++)
{
    p = i + 1;
    Console.WriteLine("O nome da cor armazenada na posição " + p + "° do vetor =" + c[i]);
}