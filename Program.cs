using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Parittomat luvut välillä 1-99:");

        for (int i = 1; i <= 99; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}