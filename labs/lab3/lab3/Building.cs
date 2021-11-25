using System.Collections.Generic;

namespace System
{
    internal class Building : Component
    {
        List<Component> entrances = new List<Component>();

        public Building(string name)
        : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in entrances)
            {
                Console.Write("        ");

                component.Display();
            }
        }

        public override void Add(Component component)
        {
            entrances.Add(component);
        }

        public override void Remove(Component component)
        {
            entrances.Remove(component);
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach (var a in entrances)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}