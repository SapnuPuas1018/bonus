using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node(T x)
        {
            this.value = x;
            this.next = null;
        }
        public Node(T x, Node<T> next)
        {
            this.value = x;
            this.next = next;
        }
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        public void SetValue(T x)
        {
            this.value = x;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public override string ToString()
        {
            return this.value + " " + this.next;
        }
    }
}
