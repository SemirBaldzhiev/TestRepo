using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    class Node<T> 
    {
        private T element;
        private Node<T> next;

        public Node(T element)
        {
            this.Element = element;
            this.Next = null;
        }
        
        public T Element { get => element; set => element = value; }
        internal Node<T> Next { get => next; set => next = value; }

        public override string ToString()
        {
            return $"{this.Element}";
        }
    }
}
