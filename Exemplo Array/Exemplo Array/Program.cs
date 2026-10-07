//CRIAR VETOR DE INTEIROS

int[] v = new int[7];

// PARA ARMAZENAR DADOS NO VERTOR
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Digite o número da posição" + i + "° do vetor: ");
    v[i] = int.Parse(Console.ReadLine());
}
//PARA MOSTRAR OS VALORES DO VETOR
for(int i = 0; i < 7; i++)
{
    Console.WriteLine("O valor da posição" + i + "° do vetor é: " + v[i]);
}