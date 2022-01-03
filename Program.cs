using System;
using CSharpDiscovery.Quest01;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] table = { "hello", "world" };
            Console.WriteLine(ConcatEverything_Exercice.ConcatEverything(table));
            string[] table2 = { "hello", "" };
            Console.WriteLine(ConcatEverything_Exercice.ConcatEverything(table2));
        }
    }
}