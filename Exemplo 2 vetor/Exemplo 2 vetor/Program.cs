//PARA CRAIR UM VETOR DE STRING
string[] nome = new string[4];

//ARMAZEAR DADOS NO VETOR
for (int i = 0; i < 4 ; i++)
{
    Console.WriteLine("Digite o nome da posição" + i + "° do vetor");
    nome[i] = Console.ReadLine();
}

//PARA MOPSTRAR VALORES VETOR
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome armazenado na posição" + i + "° do verto=" + nome[i]);
}