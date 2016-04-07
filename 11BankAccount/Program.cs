using System;

public class BankAccount
{
    public static void Main()
    {
        string first = "Stefan";
        string middle = "Petrov";
        string last = "Georgiev";
        decimal balance = 3462.42M;
        string bank = "Bulbank";
        string iban = "BG99BULB99999999999999";
        ulong creditOne = 49237973279;
        ulong creditTwo = 834257435798;
        ulong creditThree = 85403853405;
        string output = "First name:\t\t\t{0} \nMiddle name:\t\t\t{1} \nLast name:\t\t\t{2} \nBalance:\t\t\{3}             \nBank Name:\t\t{4}\nIBAN:\t\t\t{5} \nCredit Card Number #1:\t{6}\nCredit Card Number #2:\t{7}\nCredit Card Number #3:\t{8}";
        Console.WriteLine(
                    output,
                    first,
                    middle,
                    last,
                    balance,
                    bank,
                    iban,
                    creditOne,
                    creditTwo,
                    creditThree);
    }
}
