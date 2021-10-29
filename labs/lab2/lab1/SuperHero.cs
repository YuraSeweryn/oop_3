using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class SuperHero : Hero
    {
        public List<string> SuperPowers { get; private set; }

        #region Constructor
        public SuperHero()
        {
            counter++;
        }
        public SuperHero(string name, List<string> superPowers) : base(name, default)
        {
            SuperPowers = superPowers;
        }
        #endregion


        public override string SuperPower()
        {
            string answ = "My superpowers are:";
            foreach(var a in SuperPowers)
            {
                answ += $"- {a}\n";
            }
            return answ;
        }

        ~SuperHero()
        {
            Dispose(disposing: false);
            Console.WriteLine("SuperHero destructed");
        }
    }
}
