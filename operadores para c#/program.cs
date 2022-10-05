// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int Var1 = 10;
            int Var2 = 20;
            int Var3 = 30;

            for (int test = 1; test <= 5; test++)
            {
                Console.WriteLine(test);

            Console.WriteLine(Var1);
            Console.WriteLine(Var2);
            Console.WriteLine(Var3);

            Console.WriteLine(Var1 < Var2);
            Console.WriteLine(Var2 == Var3);

            Var1++;
            Var3--;

            Console.WriteLine(Var1);
            Console.WriteLine(Var3);

            Var1 = Var1 + 10;
            Var1 = Var1 + 10;
            Var1 = Var1 + 10;
            }
        }
    }
}
