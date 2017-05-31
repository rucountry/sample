using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Command
{
    /*Позволяется реализовать команду или набор команд в виде объекта*/

    internal sealed class Source
    {
        public List<Command> list = new List<Command>();
        public void SetCommand(Command c)
        {
            list.Add(c);
        }
        public void Execute()
        {
            foreach (var item in list)
            {
                if (item != null)
                    item.Execute();        
            }
        }
    }

    abstract class Command
    {
        protected Recever recever;
        public abstract void Execute();

    }
    internal sealed class ConcreteCommandA : Command
    {
        public ConcreteCommandA(Recever recever)
        {
            this.recever = recever;
        }
        public override void Execute()
        {
            if (this.recever != null)
            this.recever.Operation();
        }

    }
    internal sealed class ConcreteCommandB : Command
    {
        public ConcreteCommandB(Recever recever)
        {
            this.recever = recever;
        }
        public override void Execute()
        {
            if (this.recever != null)
            this.recever.Operation();
        }
    }

    abstract class Recever
    {
        public abstract void Operation();
    }
    internal sealed class Recever1 : Recever
    {
        public override void Operation()
        {
 	       Console.WriteLine("Запускаем исполнение команды A");
        }
    }
    internal sealed class Recever2 : Recever
    {
        public override void Operation()
        {
            Console.WriteLine("Запускаем исполнение команды B");
        }
    }

    class ClientCommand
    {
        public void Run()
        {
            Source source = new Source();
            Recever r1 = new Recever1();
            Recever r2 = new Recever2();
            Command c1 = new ConcreteCommandA(r1);
            Command c2 = new ConcreteCommandA(r2);
            source.SetCommand(c1);
            source.SetCommand(c2);

            Console.WriteLine("Ждем выполнение команд.");
            source.Execute();
        }
    }
}
