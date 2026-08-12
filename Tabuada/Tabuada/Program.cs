double t, n;
Console.WriteLine("Digite uma Tabuada : ");
t = double.Parse(Console.ReadLine());
n = t;
for(int i = 1; i <= 10; i++)
{
    t = n * i;
    Console.WriteLine(i + "*" + n + "=" + t);
}


