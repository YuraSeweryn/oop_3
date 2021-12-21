using System;

namespace lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContextStudent contextStudent = new ContextStudent();

            for (int i = 0; i < 25; i++)
            {
                contextStudent.Learn();
            }
            Console.ReadKey();
        }
    }

}

