using System;

class Program
{
    static void Main()
    {
        string txt = "А это пшеница, которая в темном " +
                     "чулане хранится, " +
                     "в доме, который построил";
        Console.WriteLine("Исходная строка:\n" + txt);
        Console.WriteLine(new string('-', 50));
        string[] Ws;
        Ws = txt.Split(' ');
        Console.WriteLine($"\nДлина массива слов (Ws.Length): {Ws.Length}\n");
        int i;
        for (i = 0; i < Ws.Length; i++)
        {
            Console.WriteLine($"Ws[{i}] = \"{Ws[i]}\"");
        }
    }
}
