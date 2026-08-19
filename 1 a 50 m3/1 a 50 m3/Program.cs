int r;
double s = 0;

for (int i = 1; i <= 50; i++)
{
    r = i % 3;
   
    if (r == 0)
    {
        Console.WriteLine(i + " é multiplo");
        s = s + i;
      
    }
}
Console.WriteLine("A soma dos numeros é: " + s);



