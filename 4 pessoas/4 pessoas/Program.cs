string[] nome = new string[4];
string[] sexo = new string[4];
int[] idade = new int[4];

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome da pessoa" + i + "° do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa" + i + "°do vetor");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da pessoa" + i + "°do vetor");
    sexo[i] = (Console.ReadLine());
}

for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome armazenado na posição" + i + "° do verto =" + nome[i]);
    Console.WriteLine("A idade armazenada na posição " + i + "° do vertor = " + idade[i]);
    Console.WriteLine("A sexo armazenada na posição " + i + "° do vertor = " + sexo[i]);
}


