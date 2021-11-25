using System.Collections.Generic;

namespace System
{
    internal class Street : Component
    {
        List<Component> buildings = new List<Component>();

        public Street(string name)
        : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in buildings)
            {
                Console.Write("      ");

                component.Display();
            }
        }

        public override void Add(Component component)
        {
            buildings.Add(component);
        }

        public override void Remove(Component component)
        {
            buildings.Remove(component);
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach (var a in buildings)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}