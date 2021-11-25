using System.Collections.Generic;

namespace System
{
    internal class Entrance : Component
    {
        List<Component> appartments = new List<Component>();

        public Entrance(string name)
        : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in appartments)
            {
                Console.Write("          ");

                component.Display();
            }
        }

        public override void Add(Component component)
        {
            appartments.Add(component);
        }

        public override void Remove(Component component)
        {
            appartments.Remove(component);
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach (var a in appartments)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}