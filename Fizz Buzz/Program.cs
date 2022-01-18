for (int i = 1; i < 101; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {

        Console.WriteLine(i + " FIZZ BUZZ");
    }
    else if (i % 3 == 0)
    {

        Console.WriteLine(i +" FIZZ");
    }
    else if (i % 5 == 0)
    {

        Console.WriteLine(i + " BUZZ");
    }
    else
    {
        Console.WriteLine(i);
    }

};
