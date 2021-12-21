using System;

namespace task4
{
    class MainApp
    {
        public static void Main()
        {
            // Abstract factory #1
            Console.WriteLine("Creating pricy products");
            AbstractFactory factoryPricy = new ConcreteFactoryPricy();
            Client client1 = new Client(factoryPricy);
            client1.WhatICreated();

            Console.WriteLine("\nCreating cheap products");
            // Abstract factory #2
            AbstractFactory factorycheap = new ConcreteFactoryCheap();
            Client client2 = new Client(factorycheap);
            client2.WhatICreated();

            // Wait for user input
            Console.ReadKey();
        }
    }

    class Client
    {
        private AbstractProductCats _abstractProductCats;
        private AbstractProductDogs _abstractProductDogs;
        private AbstractProductBirds _abstractProductBirds;

        public Client(AbstractFactory factory)
        {
            _abstractProductCats = factory.CreateProductCats();
            _abstractProductDogs = factory.CreateProductDogs();
            _abstractProductBirds = factory.CreateProductBirds();

        }

        public void WhatICreated()
        {
            _abstractProductCats.WhatIAm();
            _abstractProductDogs.WhatIAm();
            _abstractProductBirds.WhatIAm();
        }
    }
}

