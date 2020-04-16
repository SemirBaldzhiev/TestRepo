using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DynamicList
{
    public class DynamicList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int Count { get; set; }

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        public void Add(T element)
        {
            Node<T> nodeToAdd = new Node<T>(element);
            
            if (this.Count == 0)
            {
                this.head = nodeToAdd;
                this.tail = nodeToAdd;
            }
            else
            {
                tail.Next = nodeToAdd;
                tail = nodeToAdd;
            }
            
            this.Count++;
        }


        public T Remove(int index)
        {
            Node<T> currentNode = head;
            Node<T> prevNode = null;
            int currentIndex = 0;
            T currentElement = default(T);

            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    if (prevNode == null)
                    {
                        this.head = currentNode.Next;
                    }
                    else
                    {
                        prevNode.Next = currentNode.Next;
                    }

                    if (currentNode.Next == null)
                    {
                        prevNode = tail;
                    }

                    currentElement = currentNode.Element;

                    return currentElement;
                }
                
                prevNode = currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }

            return default(T);
        }

        public void Remove(T element)
        {
            Node<T> currentNode = head;
            Node<T> prevNode = null;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(element))
                {
                    prevNode.Next = currentNode.Next;
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
        

        public int IndexOf(T element)
        {
            Node<T> currentNode = head;
            int index = 0;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(element))
                {
                    return index;
                }
                index++;
                currentNode = currentNode.Next;
            }

            return -1;
        }

        public bool Contains(T element)
        {
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Element.Equals(element))
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }
    }
}
