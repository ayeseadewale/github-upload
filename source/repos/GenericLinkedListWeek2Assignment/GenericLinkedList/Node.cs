using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{  //create class for the node
    public class Node<T>
    {
        //element in the linkedlist
        public T Data { get; set; }
        //pointer to the next node
        public Node<T>? Next { get; set; }
        //constructor to asign value to the element present in d node
        public Node(T data)
        {
            Data = data;//value
            Next = null;//value
        }
    }
}
