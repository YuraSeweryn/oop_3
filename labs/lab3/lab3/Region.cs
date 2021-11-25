using System.Collections.Generic;

namespace System
{
    class Region : Component
    {
        List<Component> streets = new List<Component>();

        public Region(string name)
        : base(name)
        { }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in streets)
            {
                Console.Write("    ");

                component.Display();
            }
        }

        public override void Add(Component component)
        {
            streets.Add(component);
        }

        public override void Remove(Component component)
        {
            streets.Remove(component);
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach (var a in streets)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}
