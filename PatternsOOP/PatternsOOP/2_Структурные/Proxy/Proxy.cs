using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Proxy
{
    /*Замещает оригинальный объект объектом суррогатом.*/
    interface IProxy
    {
        void Operation();
    }

    class OriginalObject : IProxy
    {

        public void Operation()
        {
            Console.WriteLine("Выполнение оригинального объекта");
        }
    }
    class SurrogateObject : IProxy
    {
        OriginalObject oo;
        public SurrogateObject(OriginalObject oo)
        {
            this.oo = oo;
        }
        public void Operation()
        {
            this.oo.Operation();
        }
    }

    class ClientProxy
    {
        SurrogateObject so = new SurrogateObject(new OriginalObject());
        public void Run()
        {
            so.Operation();
        }
    }
}
