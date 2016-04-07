using System;


class Exchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("{0}, {1}", a, b);

        int temporary = a;
        a = b;
        b = temporary;
        Console.WriteLine("{0}, {1}", a, b);

    }
}

