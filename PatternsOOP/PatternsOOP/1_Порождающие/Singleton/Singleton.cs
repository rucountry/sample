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
        private static Singleton _objsingleton;
        private static object syncRoot = new object();
        private Singleton() { }

        public int ID { get; set; }

        public static Singleton Create()
        {
            if (_objsingleton == null)
            {
                lock (syncRoot)
                {
                    if (_objsingleton == null)
						_objsingleton = new Singleton();
                }
            }
            return _objsingleton;
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
