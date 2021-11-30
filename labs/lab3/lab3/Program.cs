using System.Collections.Generic;

namespace System
{
    class Client
    {
        static void Main()
        {
            Composite root = new Composite("City");
            Composite district = new District("Bronx");
            Composite street = new Street("Main ave");
            Composite building = new Building("42");
            Composite entrance1 = new Entrance("entr3");
            Component appartment1 = new Appartment("apart69", 4);
            Composite entrance2 = new Entrance("entr2");
            Component appartment2 = new Appartment("apart694", 10);

            root.Add(district);
            district.Add(street);
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
        internal List<Component> childrens = new List<Component>();
        internal string blankspace = "  ";
        public Composite(string name)
        : base(name)
        { }

        public override void Add(Component component)
        {
            childrens.Add(component);
        }

        public override void Remove(Component component)
        {
            childrens.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name);

            foreach (Component component in childrens)
            {
                Console.Write(blankspace);
                component.Display();
            }
        }

        public override int GetNumberOfPeople()
        {
            int sum = 0;
            foreach(var a in childrens)
            {
                sum += a.GetNumberOfPeople();
            }

            return sum;
        }
    }
}