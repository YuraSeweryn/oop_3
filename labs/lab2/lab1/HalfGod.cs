using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{

    class HalfGod : IDisposable, ICarma, IDoneGood
    {
        #region Properties and Fields

        string name;
        private bool disposedValue;

        public string Name
        {
            get
            {
                return $"My name is {name}";
            }
            set
            {
                name = value;
            }
        }

        public static int TotalKarma { get; set; }
        #endregion

        #region Constructors
        public HalfGod(string name)
        {
            Name = name;
            TotalKarma = 0;
        }
        static HalfGod()
        {
            TotalKarma = 0;
        }

        public HalfGod()
        {
        }
        #endregion

        void ICarma.IncreaseCarma()
        {
            TotalKarma++;
        }
        void IDoneGood.IncreaseCarma()
        {
            TotalKarma++;
        }

        public void DecreaseCarma()
        {
            TotalKarma--;
        }

        protected virtual void Dispose(bool disposing)
        {
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
        }

        ~HalfGod()
        {
            Dispose(disposing: false);
            Console.WriteLine("HalfGod destructed");
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
