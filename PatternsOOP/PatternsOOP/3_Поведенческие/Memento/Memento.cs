using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Memento
{
    /*Реализует логику сохранения состояния*/

    class Originator
    {
        private string state;
        public string State { get { return state; } set { state = value; } }

        public Memento CreateMemento()
        {
            return new Memento(this.state);
        }
        public void GetState(Memento m)
        {
            this.state = m.State;
        }
    }
    class Memento
    {
        private string state;
        public string State { get { return state; } }
        public Memento(string state)
        {
            this.state = state;
        }
    }
    class Caretaker
    {
        private Memento m;
        public Memento Memento { get { return m; } }
        public Caretaker(Memento m)
        {
            this.m = m;
        }
    }


    class ClientMemento
    {
        public void Run()
        {
            Originator o = new Originator();
            o.State = "First State";
            Console.WriteLine(o.State);
            Caretaker c = new Caretaker(o.CreateMemento());
            
            Console.WriteLine("Какие-то действия");
            Console.WriteLine("Меняем состояние");
            o.State = "Second state";
            Console.WriteLine(o.State);
            Console.WriteLine("Меняем состояние обратно");
            o.GetState(c.Memento);
            Console.WriteLine(o.State);

        }
    }
}
