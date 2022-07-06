using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    internal class Stack<T>
    {
        private LinkedList<T> _linkedList;

        public Stack()
        {
            _linkedList = new LinkedList<T>();
        }

        public void Push(T element)
        {
            _linkedList.AddToHead(element);
        }
        //removes and returns the last item added to the stack
        public T Pop()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException("Stack empty");
            }
            T removedItem = _linkedList.Head.Data;
            _linkedList.Remove(removedItem);
            return removedItem;
        }

        public T Peek()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException("Stack empty");
            }
            return _linkedList.Head.Data;
        }

        public bool IsEmpty()
        {
            return _linkedList.Count == 0;
        }

        public int Size()
        {
            return _linkedList.Count;
        }
        public void Print()
        {
            Node<T>? temp = _linkedList.Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
