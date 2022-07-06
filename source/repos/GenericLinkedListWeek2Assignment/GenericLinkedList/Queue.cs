using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class Queue<T>
    {
        private LinkedList<T> _linkedList;

        public Queue()
        {
            _linkedList = new LinkedList<T>();
        }

        public void Enqueue(T element)
        {
            _linkedList.AddToTail(element);
        }

        public T Dequeue()
        {
            if( _linkedList.Count == 0)
            {
                throw new InvalidOperationException("Queue empty");
            }
            T removedItem = _linkedList.Head.Data;
            _linkedList.Remove(removedItem);
            return removedItem;
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
