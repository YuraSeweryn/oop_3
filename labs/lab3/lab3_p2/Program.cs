namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            IDecanat document = new DecanatProxy();
            Student s1 = new Student("Ivan Ivanov", 69);
            Student s2 = new Student("Petr Petrov", 42);

            var doc1 = document.GetDocuments(1);
            Console.WriteLine(doc1.text + "\n");

            var doc2 = document.GetDocuments(2);
            Console.WriteLine(doc2.text);

            Console.Read();
        }
    }

    interface IDecanat
    {
        Documents GetDocuments(int number);
    }

    class Decanat : IDecanat
    {
        public Documents GetDocuments(int id)
        {
            if (Student.students[id - 1].Grade > 60)
            {
                return Student.students[id - 1].GenerateDoc();
            }
            throw new Exception();
        }
    }
}