using System;

namespace lab1
{
    sealed class God : HalfGod
    {
        bool HaveCreatedWorld;

        public God()
        {
        }

        public string IsOurGod()
        {
            if (HaveCreatedWorld)
            {
                return "I'm God, I've created world";
            }
            return "I haven't created world(";
        }

        public God(string name, bool haveCreatedWorld) : base(name)
        {
            HaveCreatedWorld = haveCreatedWorld;
        }

        ~God()
        {
            Dispose(disposing: false);
            Console.WriteLine("God destructed");
        }

    }
}
