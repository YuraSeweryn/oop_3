using System;
using System.Collections.Generic;
using System.Threading;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p1 = new Person("Ivan Ivanov", DateTime.Now.AddDays(1));
            }
            catch (InvalidDateException ex)
            {
                Console.WriteLine("Have caugth exception: " + ex.Message);
            }

            Person p2 = new Person("EVA Braun");
            Console.WriteLine(p2.Beep());

            Console.WriteLine();
            Person p3 = new Person("Pupkin");
            p3.FeedEvent += Notify;
            p3.FeedEvent += anonimMethod;
            p3.FeedEvent += lambda;
            p3.Feed(10);
            #region lab1
            //Person p1 = new Person("Ada Johns");
            //SuperHero sh1 = new SuperHero("Ivan Ivanov", new List<string> { "1 superpower", "2 superpower" });
            //Console.WriteLine(p1.Introduce());
            //Console.WriteLine(sh1.Introduce());
            //Console.WriteLine(Person.HowMany() + "\n");

            //Console.WriteLine("Memory before collect: " + GC.GetTotalMemory(false));
            //Console.WriteLine("Generation: " + GC.GetGeneration(p1));
            //GC.Collect(2, GCCollectionMode.Forced);
            //GC.WaitForPendingFinalizers();
            //Console.WriteLine("Memory after collect: " + GC.GetTotalMemory(false));
            //Console.WriteLine("Generation: " + GC.GetGeneration(p1));
            //Console.WriteLine();

            //sh1.Dispose();
            #endregion

            Console.ReadKey();
        }

        public static void Notify(string message)
        {
            Console.WriteLine("Notify   " + message);
        }

        static FeedPerson anonimMethod = delegate (string mes)
        {
            Console.WriteLine("anonimMethod  "+ mes);
        };

        static FeedPerson lambda = (s) => Console.WriteLine("lambda   "+ s);

    }

    public static class ExtensionsClass
    {
        public static string Beep(this Person pers)
        {
            Console.Beep();
            return "Beep boop boop";
        }

    }
}