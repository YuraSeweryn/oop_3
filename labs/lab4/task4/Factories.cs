using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductCats CreateProductCats();
        public abstract AbstractProductDogs CreateProductDogs();
        public abstract AbstractProductBirds CreateProductBirds();

    }

    class ConcreteFactoryCheap : AbstractFactory
    {
        public override AbstractProductCats CreateProductCats()
        {
            return new ProductCatsCheap();
        }
        public override AbstractProductDogs CreateProductDogs()
        {
            return new ProductDogsCheap();
        }
        public override AbstractProductBirds CreateProductBirds()
        {
            return new ProductBirdsCheap();
        }
    }

    class ConcreteFactoryPricy : AbstractFactory
    {
        public override AbstractProductCats CreateProductCats()
        {
            return new ProductCatsPricy();
        }
        public override AbstractProductDogs CreateProductDogs()
        {
            return new ProductDogsPricy();
        }
        public override AbstractProductBirds CreateProductBirds()
        {
            return new ProductBirdsPricy();
        }
    }
}
