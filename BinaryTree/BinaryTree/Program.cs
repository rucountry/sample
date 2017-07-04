using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> instance = new BinaryTree<int>();

            instance.Add(8);    //                        8
            instance.Add(5);    //                      /   \
            instance.Add(12);   //                     5    12 
            instance.Add(3);    //                    / \   / \  
            instance.Add(7);    //                   3   7 10 15
            instance.Add(10);   //
            instance.Add(15);   //

            Console.WriteLine("Количество узлов в дереве:{0}", instance.Count);
        }
    }
    // узел бинарного дерева
    class BinaryTreeNode<T> : IComparable<T>  where T : IComparable<T>
    {
        private BinaryTreeNode<T> _left;
        private BinaryTreeNode<T> _right;
        private T _value;
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public BinaryTreeNode<T> Left { get { return _left; } set { _left = value; } }
        public BinaryTreeNode<T> Right { get { return _right; } set { _right = value; } }

        public BinaryTreeNode(T value)
        {
            this._value = value;
        }



        public int CompareTo(T other)
        {
            return this.Value.CompareTo(other);
        }
        public int CompareTo(BinaryTreeNode<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
    // дерево
    class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        BinaryTreeNode<T> _head;
        public int Count { get; set; }


        public void Add(T value)
        {
            if (_head == null)
                _head = new BinaryTreeNode<T>(value);
            else
                AddToNode(_head, value);
            Count++;
        }
        public void AddToNode(BinaryTreeNode<T> node, T value)
        {
            if (node != null)
            {
                int result = value.CompareTo(node.Value);
                if (result < 0)
                {
                    if (node.Left == null)
                        node.Left = new BinaryTreeNode<T>(value);
                    else AddToNode(node.Left, value);
                }
                else
                {
                    if (node.Right == null)
                        node.Right = new BinaryTreeNode<T>(value);
                    else AddToNode(node.Right, value);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
