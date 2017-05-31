using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Composite
{

    /*Реализация древовидной страктуры*/

    abstract class Component
    {
        public string Name { get; set; }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract Component GetByID(int i);
        public abstract void GetAll();
    }
    internal sealed class Leaf : Component
    {
        public Leaf(string name) { Name = name; }
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
        public override Component GetByID(int i)
        {
            return this;
        }
        public override void GetAll()
        {
            Console.WriteLine(this.Name);
        }
    }
    internal sealed class Composite : Component
    {
        List<Component> list = new List<Component>();
        public Composite(string name) { Name = name; }
        public override void Add(Component c)
        {
            list.Add(c);
        }
        public override void Remove(Component c)
        {
            list.Remove(c);
        }
        public override Component GetByID(int i)
        {
            return list[i];
        }
        public override void GetAll()
        {
            Console.WriteLine(this.Name);
            foreach (var item in list)
            {
                item.GetAll();
            }
        }
    }

    internal sealed class ClientComposite
    {
        public void Run()
        {
            Component root = new Composite("root");
            Component branch1 = new Composite("branch1");
            Component branch2 = new Composite("branch2");
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");
            Component leaf3 = new Leaf("leaf3");
            Component leaf4 = new Leaf("leaf4");
            Component leaf5 = new Leaf("leaf5");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch1.Add(leaf2);
            branch2.Add(leaf3);
            branch2.Add(leaf4);
            branch2.Add(leaf5);

            root.GetAll();

        }
    }
}
