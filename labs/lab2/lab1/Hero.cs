using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Hero : Person, IDisposable, ISuperPower
    {
        public string Power { get; private set; }

        #region Constructors
        public Hero()
        {
            counter++;
        }

        public Hero(string name, string power) : base(name)
        {
            Power = power;
        }

        #endregion
        
        public virtual string SuperPower()
        {
            return $"My SuperPower is: {Power}";
        }

        ~Hero()
        {
            Dispose(disposing: false);
            Console.WriteLine("Hero destructed");
        }
    }
}
