using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Iterator
{
    /*Перечислитель*/
    interface IEnumerable1<T>
    {
        IEnumerator1<T> GetEnumerator();
        int Count { get; }
    }
    interface IEnumerator1<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();
    }

    class Enumerable<T> : IEnumerable1<T>
    {
        List<T> list = new List<T>();
        public IEnumerator1<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        public int Count
        {
            get { return list.Count; }
        }
        public T this[int i]
        {
            get { return list[i]; }
            set { list.Insert(i, value); }
        }
    }
    class Enumerator<T> : IEnumerator1<T>
    {
        int current = -1;
        Enumerable<T> enumerable;
        
        public Enumerator(Enumerable<T> enumerable)
        {
            this.enumerable = enumerable;
        }

        public T Current
        {
            get { return enumerable[current]; }
        }

        public bool MoveNext()
        {
            if (current < enumerable.Count - 1)
            {
                current++;
                return true;
            }
            else return false;
        }

        public void Reset()
        {
            current = -1;
        }
       
    }

    class ClientIterator
    {
        public void Run() 
        {
            Enumerable<int> list = new Enumerable<int>();
            list[0] = 0;
            list[1] = 1;
            list[2] = 2;

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Enumerable<string> list1 = new Enumerable<string>();
            list1[0] = "0";
            list1[1] = "1";
            list1[2] = "2";

            Console.WriteLine("------------------");
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
