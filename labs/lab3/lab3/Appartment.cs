using System.Collections.Generic;

namespace System
{
    internal class Appartment : Component
    {
        int peopleLives;

        public Appartment(string name, int people = 0): base(name)
        {
            peopleLives = people; 
        }

        public override void Display()
        {
            Console.WriteLine(name);
        }

        public void ChangeLivings(int c)
        {
            peopleLives = c;
        }

        public override void Remove(Component c) { }

        public override int GetNumberOfPeople()
        {
            return peopleLives;
        }

        public override void Add(Component c) { }
    }
}