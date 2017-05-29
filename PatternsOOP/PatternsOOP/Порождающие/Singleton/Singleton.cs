using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Singleton
{
    /*Порождение только единичного объекта*/
    class Singleton
    {
        private static Singleton obj;
        private static object sync = new object();
        protected Singleton() { }

        public int ID { get; set; }

        public static Singleton Create()
        {
            if (obj == null)
            {
                lock (sync)
                {
                    if (obj == null)
                        obj = new Singleton();
                }
            }
            return obj;
        }
    }

    internal sealed class ClientSingleton
    {
        public void Run()
        {
            Singleton s = Singleton.Create();
            s.ID = 1;
            Singleton s2 = Singleton.Create();
            Console.WriteLine(s2.ID);
        }
    }

}
