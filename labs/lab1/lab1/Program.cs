using System;
using System.Collections.Generic;
using System.Threading;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ada Johns");
            SuperHero sh1 = new SuperHero("Ivan Ivanov", new List<string> { "1 superpower", "2 superpower" });
            Console.WriteLine(p1.Introduce());
            Console.WriteLine(sh1.Introduce());
            Console.WriteLine(Person.HowMany() + "\n");

            Console.WriteLine("Memory before collect: " + GC.GetTotalMemory(false));
            Console.WriteLine("Generation: " + GC.GetGeneration(p1));
            GC.Collect(2, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("Memory after collect: " + GC.GetTotalMemory(false));
            Console.WriteLine("Generation: " + GC.GetGeneration(p1));
            Console.WriteLine();

            sh1.Dispose();


            Console.ReadKey();
        }
    }
}