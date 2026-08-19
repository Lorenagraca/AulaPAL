int r, qt=0;

for (int i = 1; i <= 300; i++)
{
    r = i % 3;
    if (r == 0)
    {
        Console.WriteLine(i + " é multiplo");
        qt++;
    }
}
Console.WriteLine( "A quantidade de mutiplos é:" + qt );
