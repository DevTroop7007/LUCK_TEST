using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\t\t\t---------------------");
        Console.WriteLine("\t\t\t\t   LUCK TEST");
        Console.WriteLine("\t\t\t---------------------");
        Console.WriteLine("\tTest your luck and compare with another");
        Console.WriteLine("=================================================");

        Console.WriteLine("NOTE : Luck is dependent on Almighty");
        Console.ResetColor();
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("Enter 1st player name:");
        string a = Console.ReadLine();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter 2nd player name:");
        string b = Console.ReadLine();
        Console.ResetColor();

        Console.WriteLine("Let's show Whose luck is best and with whom the almighty is!!!");
        Console.WriteLine("");
        Random NumGen = new Random();


        int luck1 = NumGen.Next(1, 11);
        int luck2 = NumGen.Next(1, 11);
        int luck3 = NumGen.Next(1, 11);
        int luck4 = NumGen.Next(1, 11); ;
        int luck5 = NumGen.Next(1, 11);
        int luck6 = NumGen.Next(1, 11); ;
        int luck7 = NumGen.Next(1, 11);
        int luck8 = NumGen.Next(1, 11);
        int luck9 = NumGen.Next(1, 11);
        int luck10 = NumGen.Next(1, 11);
        int luck11 = NumGen.Next(1, 11);
        int luck12 = NumGen.Next(1, 11);
        int luck13 = NumGen.Next(1, 11);
        int luck14 = NumGen.Next(1, 11);
        int luck15 = NumGen.Next(1, 11);
        int luck16 = NumGen.Next(1, 11);
        int luck17 = NumGen.Next(1, 11);
        int luck18 = NumGen.Next(1, 11);
        int luck19 = NumGen.Next(1, 11);
        int luck20 = NumGen.Next(1, 11);


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(a + "'s luck = " + luck1);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck2);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck3);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck4);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck5);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck6);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck7);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck8);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck9);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck10);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck11);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck12);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck13);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck14);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck15);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck16);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck17);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck18);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ReadKey();
        Console.WriteLine(a + "'s luck = " + luck19);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.ReadKey();
        Console.WriteLine(b + "'s luck = " + luck20);
        Console.ResetColor();
        Console.ReadKey();

        int tl1 = luck1 + luck3 + luck5 + luck7 + luck9 + luck11 + luck13 + luck15 + luck17 + luck19;
        Console.WriteLine(a + "'s total luck = " + tl1);
        int tl2 = luck2 + luck4 + luck6 + luck8 + luck10 + luck12 + luck14 + luck16 + luck18 + luck20;
        Console.WriteLine(b + "'s total luck = " + tl2);
    }
}
