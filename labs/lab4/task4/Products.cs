using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    #region Abstract products
    abstract class AbstractProductCats
    {
        public abstract void WhatIAm();
    }

    abstract class AbstractProductDogs
    {
        public abstract void WhatIAm();
    }
    abstract class AbstractProductBirds
    {
        public abstract void WhatIAm();
    }
    #endregion

    class ProductCatsCheap : AbstractProductCats
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Cheap cats products");
        }
    }

    class ProductDogsCheap : AbstractProductDogs
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Cheap dogs products");
        }
    }

    class ProductCatsPricy : AbstractProductCats
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Pricy cats products");
        }
    }

    class ProductDogsPricy : AbstractProductDogs
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Pricy dogs products");
        }
    }

    class ProductBirdsPricy : AbstractProductBirds
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Pricy birds products");
        }
    }
    class ProductBirdsCheap : AbstractProductBirds
    {
        public override void WhatIAm()
        {
            Console.WriteLine( "Cheap birds products");
        }
    }
}
