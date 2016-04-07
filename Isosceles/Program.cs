using System;
using System.Text;

class Isosceles
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char Symbol = '\u00A9';
                 string firstLine = "   {0}\n\n";
                 string secondLine = "  {0} {0}\n\n";
                 string thirdLine = " {0}   {0}\n\n";
                 string fourthLine = "{0} {0} {0} {0}";
        

        Console.WriteLine(firstLine + secondLine + thirdLine + fourthLine, Symbol);


    }
}
