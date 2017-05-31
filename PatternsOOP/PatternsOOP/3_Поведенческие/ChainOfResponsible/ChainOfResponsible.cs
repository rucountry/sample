using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.ChainOfResponsible
{
    /*Создает цепочки из обработчиков запросов*/

    abstract class Handle
    {
        public Handle Successor { get; set; }
        public abstract void HandleRequest(int i);
    }
    internal sealed class ConcreteHandle1 : Handle
    {
        public override void HandleRequest(int i)
        {
            if (i == 1)
                Console.WriteLine("Обработчик 1 выполняет работы");
            else if (Successor != null)
            {
                Console.WriteLine("Обработчик {0} отдает запрос следующему обработчику", i);
                Successor.HandleRequest(i);
            }
        }
    }
    internal sealed class ConcreteHandle2 : Handle
    {
        public override void HandleRequest(int i)
        {
            if (i == 2)
                Console.WriteLine("Обработчик 2 выполняет работы");
            else if (Successor != null)
            {
                Console.WriteLine("Обработчик {0} отдает запрос следующему обработчику", i);
                Successor.HandleRequest(i);
            }
        }
    }

    class ClientChain
    {
        public void Run()
        {
            Handle h1 = new ConcreteHandle1();
            Handle h2 = new ConcreteHandle2();
            h1.Successor = h2;

            h1.HandleRequest(1);
            Console.WriteLine("------------------------------");
            h1.HandleRequest(2);
        }
    }
}
