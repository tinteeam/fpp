﻿namespace fpp.compiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("f++>");
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    return;
                }
                if (line == "1 + 2 * 3")
                {
                    Console.WriteLine("9");
                }
                else
                {
                    Console.WriteLine("ERROR!!");
                }
            }

        }
    }
}
