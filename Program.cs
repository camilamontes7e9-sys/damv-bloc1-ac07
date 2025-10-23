
using System;
namespace Activitat1;
public class Program
{
    public static void Main()
    {
        const string Msg = "Enter a number to check if tit's a natural number: ";
        const string Msg2 = "It's not a natural number.";
        const string Msg3 = "Congrats, it's a natural number!";

        int num;

        Console.WriteLine(Msg);
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine(Msg3);

        }
        else
        {
            Console.WriteLine(Msg2);
        }
    }
}