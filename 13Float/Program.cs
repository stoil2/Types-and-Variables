using System;

class Floats
{
    static void Main()
    {
        double doubleOne = double.Parse(Console.ReadLine());
        double doubleTwo = double.Parse(Console.ReadLine());
        bool equal = Math.Abs(doubleOne - doubleTwo) < 0.000001;
        if (equal)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
