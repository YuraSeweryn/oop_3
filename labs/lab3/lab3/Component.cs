using System.Collections.Generic;

namespace System
{
    abstract class Component
    {
        public string name { get; private set; }

        public int number { get; private set; }

        public Component(string name)
        {
            this.name = name;

        }
        public abstract int GetNumberOfPeople();

        public abstract void Display();

        public abstract void Add(Component c);

        public abstract void Remove(Component c);
    }
}