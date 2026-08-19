double n, s=0;

for(int i = 1; 1<= 10; i++ )
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Digite o numero: ");
    n = double.Parse(Console.ReadLine());

    s = n + s;

    Console.WriteLine(i);
}
