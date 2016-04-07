using System;

public class Null
{
    public static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
       
        Console.WriteLine("{0}, {1}", nullInteger, nullDouble);

        nullInteger = nullInteger+10;
        nullDouble += 86.2;
        Console.WriteLine("{0}, {1}", nullInteger, nullDouble);
    }
}