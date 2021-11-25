using System.Collections.Generic;

namespace System
{
    class Client
    {
        static void Main()
        {
            Composite root = new Composite("City");
            Component region = new Region("Bronx");
            Component street = new Street("Main ave");
            Component building = new Building("42");
            Component entrance1 = new Entrance("entr3");
            Component appartment1 = new Appartment("apart69", 4);
            Component entrance2 = new Entrance("entr2");
            Component appartment2 = new Appartment("apart694", 10);

            root.Add(region);
            region.Add(street);
            street.Add(building);
            building.Add(entrance1);
            building.Add(entrance2);
            entrance1.Add(appartment1);
            entrance2.Add(appartment2);

            root.Display();

            Console.WriteLine($"\nIn city lives: {AllPeople(root)}\nIn {street.name} lives: {street.GetNumberOfPeople()}");
            Console.WriteLine($"In {entrance1.name} lives: {entrance1.GetNumberOfPeople()}\nIn {entrance2.name} lives: {entrance2.GetNumberOfPeople()}");

            Console.ReadKey();
        }
        public static int AllPeople(Component root)
        {
            return root.GetNumberOfPeople();
        }

    }

    class Composite : Component
    {
        List<Component> Regions = new List<Component>();

        public Composite(string name)
        : base(name)
        { }

        public override void Add(Component component)
        {
            Regions.Add(component);
        }

        public override void Remove(Component component)
        {
            Regions.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in Regions)
            {
                Console.Write("  ");
                component.Display();
            }
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach(var a in Regions)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}