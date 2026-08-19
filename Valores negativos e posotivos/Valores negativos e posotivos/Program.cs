double n;
int qtp =0, qtn =0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um numero: ");
    n = double.Parse(Console.ReadLine());

    if (n > 0)
    {
        qtp++;
    }
    else if(n < 0)
    {
        qtn++;
    }

}
    Console.WriteLine("A quantidade de positivos são: " + qtp);
    Console.WriteLine("A quantidade de negativos são: " + qtn);