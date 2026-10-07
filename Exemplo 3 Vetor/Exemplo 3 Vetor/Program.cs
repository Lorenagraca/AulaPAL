//PARA CRAIR UM VETOR DE STRING
string[] nome = new string[4];
//PARA CRIAR UM VETOR DE INT
int[] idade = new int[4];

//ARMAZEAR DADOS NO VETOR
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite o nome da posição" + i + "° do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição" + i + "°do vetor");
    idade[i] = int.Parse(Console.ReadLine());
}

//PARA MOPSTRAR VALORES VETOR
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome armazenado na posição" + i + "° do verto =" + nome[i]);
    Console.WriteLine("A idade armazenada na posição " + i + "° do vertor = " + idade[i]);
}

