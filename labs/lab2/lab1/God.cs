using System;

namespace lab1
{
    sealed class God : HalfGod
    {
        bool HaveCreatedWorld;
        static God CreateOurGod(string confirmation)
        {
            if(confirmation == "Create God")
            {
                return new God("GOD", true);
            }

            throw new AccessViolationException("Wrong confirmation password!");
        }
        God(string name, bool b)
        {
            HaveCreatedWorld = b;
        }

        public God(string name) : base(name)
        {
            HaveCreatedWorld = false;
        }

        public string IsOurGod()
        {
            if (HaveCreatedWorld)
            {
                return "I'm God, I've created world";
            }
            return "I haven't created world(";
        }


        ~God()
        {
            Dispose(disposing: false);
            Console.WriteLine("God destructed");
        }

    }
}
