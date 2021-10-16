using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Person : IDisposable
    {
        #region Properties and Fields
        internal static long counter;
        DateTime bornDate;
        private bool disposedValue;
        string name;

        public virtual string Name
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
                    throw new ArgumentException("Can`t be born in future");
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


        public string Introduce()
        {
            return $"Hi I'm {Name}, and I was born on {BornDate.Date}. I'm {this.GetType().Name}";
        }
        public static string HowMany()
        {
            return $"There are {counter} of us";
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
