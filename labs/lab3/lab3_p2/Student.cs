using System.Collections.Generic;

namespace System
{
    class Student
    {
        public static List<Student> students = new List<Student>();

        public Student()
        {
        }

        public Student(string name, float grade)
        {
            Id = students.Count + 1;
            Name = name;
            Grade = grade;
            students.Add(this);
        }

        public Student(string name, float grade, object data)
        {
            Id = students.Count + 1;
            Name = name; 
            Grade = grade;
            Data = data;
            students.Add(this);
        }

        public Documents GenerateDoc()
        {
            return new Documents(Id + "|" + Name + "|" + Grade);
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        public float Grade { get; private set; }
        public object Data { get; set; }
    }
}