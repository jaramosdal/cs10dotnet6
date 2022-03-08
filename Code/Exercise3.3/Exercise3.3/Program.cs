using static System.Console;

for (int i = 0; i <= 100; i++)
{
    if (i%3==0 && i % 5 == 0)
    {
        Write("fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Write("fizz");
    }
    else if (i % 5 == 0)
    {
        Write("buzz");
    }
    else
    {
        Write(i);
    }

    if (i < 100)
    {
        Write(", ");
    }
}