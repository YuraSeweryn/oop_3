using System;

namespace lab5
{
    public abstract class State
    {
        public int percents { get; private protected set; }

        abstract public void CurrentPercent();
    }
    class A_State : State
    {
        public A_State()
        {
            percents = 95;
        }
        override public void CurrentPercent()
        {
            Console.WriteLine("I have >95 points. I`m learning");
        }
    }
    class B_State : State
    {
        public B_State()
        {
            percents = 80;
        }
        override public void CurrentPercent()
        {
            Console.WriteLine("I have 80-95 points. I`m learning");
        }
    }
    class С_State : State
    {
        public С_State()
        {
            percents = 60;
        }
        override public void CurrentPercent()
        {
            Console.WriteLine("I have 60-80 points. I`m learning");
        }
    }

    class NA_State : State
    {
        public NA_State()
        {
            percents = 0;
        }
        override public void CurrentPercent()
        {
            Console.WriteLine("I have big problems. I`m learning");
        }
    }
}
