using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Mediator
{
    /*Предоставляет объект-посредник, который реализует всю логику взаимоотношений*/

    interface IColleague
    {
        void Send();
        void Notify(string s);
    }
    internal sealed class Colleague1 : IColleague
    {
        string State;
        Mediator mediator;
        public Colleague1(Mediator mediator)
        {
            this.mediator = mediator;
            this.State = "состояние";
        }
        public void Send()
        {
            Console.WriteLine("Колега 1 вызывает посредника");
            mediator.Operation(this,this.State);
        }
        public void Notify(string s) 
        {
            Console.WriteLine("Первый колега получил от посредника сообщение: {0}", State);
        }

    }
    internal sealed class Colleague2 : IColleague
    {
        string State;
        Mediator mediator;
        public Colleague2(Mediator mediator)
        {
            this.mediator = mediator;
            this.State = "состояние";
        }
        public void Send()
        {
            Console.WriteLine("Колега 2 вызывает посредника");
            mediator.Operation(this,this.State);
        }
        public void Notify(string s)
        {
            Console.WriteLine("Второй колега получил от посредника сообщение: {0}", State);
        }

    }

    class Mediator
    {
        public Colleague1 colleague1 { get; set; }
        public Colleague2 colleague2 { get; set; }

        public void Operation(IColleague col, string state)
        {
            if (col == colleague1)
            {
                colleague2.Notify(state);
            }
            else if (col == colleague2)
            {
                colleague1.Notify(state);
            }
        }
    }

    class ClientMediator
    {
        public void Run()
        {
            Mediator mediator = new Mediator();
            Colleague1 col1 = new Colleague1(mediator);
            Colleague2 col2 = new Colleague2(mediator);
            mediator.colleague1 = col1;
            mediator.colleague2 = col2;

            col1.Send();
            Console.WriteLine("------------------------------");
            col2.Send();
        }
    }
}
