using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Adapter
{
    /*Адаптировать несовместимые интерфейсы*/

    /*1 - вариант, через наследование*/
    interface ITarget
    {
        void Operation(); 
    }
    class AdapteePepsi1
    {
        public void CreatePepsi1()
        {
            Console.WriteLine("Производим напиток Pepsi");
        }
    }
    class Adapter : AdapteePepsi, ITarget
    {
        public void CreatePepsi1()
        {
        }

        public void Operation()
        {
            base.CreatePepsi();
        }
    }
    class ClientAdapterV1
    {
        public void Run()
        {
            ITarget target = new Adapter();
            target.Operation();
        }
    }

    /*2 - вариант, через агрегацию. Предпочтительный*/
    interface ITarget2
    {
        void Operation();
    }
    class AdapteePepsi
    {
        public void CreatePepsi()
        {
            Console.WriteLine("CreatePepsi");
        }
    }
    class AdapteeCocaCola
    {
        public void CreateCocaCola()
        {
            Console.WriteLine("CreateCocaCola");
        }
    }
    class AdapteeLipton
    {
        public void CreateLipton()
        {
            Console.WriteLine("CreateLipton");
        }
    }
    class AdapterMulti : ITarget2
    {
        AdapteePepsi adapteePepsi;
        AdapteeCocaCola adapteeCocaCola;
        AdapteeLipton adapteeLipton;
        public AdapterMulti()
        {
            this.adapteePepsi = new AdapteePepsi();
        }
        public void Operation()
        {
            if (this.adapteePepsi != null)
            adapteePepsi.CreatePepsi();
        }
    }
    class ClientAdapterV2
    {
        public void Run()
        {
            ITarget2 target2 = new AdapterMulti();
            target2.Operation();
        }
    }
}
