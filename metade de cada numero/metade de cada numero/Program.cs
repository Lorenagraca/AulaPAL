double num, met;

for (int i = 1; i <=10; i++)
{
    Console.WriteLine("Digite um numeros: ");
    num = double.Parse(Console.ReadLine());

    met = num / 2;
    Console.WriteLine("A metade é: " +  met);
    Console.WriteLine(i);

}