using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Hero : Person, IDisposable
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
