using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public delegate void FeedPerson(string s);

    public class Person : Being, IDisposable
    {
        public event FeedPerson FeedEvent;
        Action<string> action = Notify;
        Func<string, string> function = str => { Console.WriteLine(str); return ""; };

        private static void Notify(string obj)
        {
            Console.WriteLine(obj);
        }

        #region Properties and Fields
        internal static long counter;
        DateTime bornDate;
        private bool disposedValue;
        string name;
        int Hunger = 0;

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        DateTime BornDate
        {
            get
            {
                return bornDate;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new InvalidDateException("Born date " + value.ToLongDateString());
                }
                bornDate = value;
            }
        }
        #endregion

        #region Constructor
        static Person()
        {
            counter = 0;
        }
        public Person()
        {
            counter++;
        }
        public Person(string name)
        {
            Name = name;
            BornDate = DateTime.Now;
            counter++;
        }
        internal protected Person(string name, DateTime date)
        {
            Name = name;
            BornDate = date;
            counter++;
        }
        #endregion

        public void Feed(int feed)
        {
            Hunger += feed;
            if (FeedEvent != null)
            {
                FeedEvent.Invoke($"1. I'm {name} and my hunger is: {Hunger}");
                action($"2. I'm {name} and my hunger is: {Hunger}");
                function($"3. I'm {name} and my hunger is: {Hunger}");
            }
        }

        public override string Introduce()
        {
            return $"Hi I'm {Name}, and I was born on {BornDate.Date}. I'm {this.GetType().Name}";
        }

        #region GC
        protected virtual void Dispose(bool disposing)
        {
            GC.SuppressFinalize(true);
            if (!disposedValue)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing managed resourses");
                }

                Console.WriteLine("Disposing unmanaged resourses");
                name = null;
                disposedValue = true;
            }
            GC.ReRegisterForFinalize(this);
        }
        ~Person()
        {
            Dispose(disposing: false);
            Console.WriteLine("Person destructed");
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
