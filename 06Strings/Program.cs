﻿using System;


class Strings
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object c = a + ' ' + b;
        string d = (string)c;
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}
