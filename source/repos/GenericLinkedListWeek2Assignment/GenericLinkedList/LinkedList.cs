using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLinkedList
{
    public class LinkedList<T>
    {//head of d linkedlist(1st item in d linkedlist)
        public Node<T>? Head;
        public int Count { get; private set; }//d count of how many element we have in d list
        public LinkedList()
        {
            Head = null;//value
            Count = 0;//value
        }

        //we are adding element to d linkedlist from d back
        public void AddToTail(T element)
        {
            Node<T> node = new Node<T>(element);
            if(Head == null)//d head is null by default which is equal to d new node created
            {
                Head = node;//node is d element & pointer but its called node present in d linkedli
            }
            else
            {//d next node is d new element added to d list
                Node<T> temp = Head; //create a temporal node asign to d head for transversing. i.e iterate through d linkedlist
                while(temp.Next != null)   //To know if it not = null
                {
                    temp = temp.Next;//temp is = next node if d next node is not null
                }
                temp.Next = node;//if its null then asign newly created node to d null
            }
            Count++;//increase d count of node in d linkedlist
        }

        public void AddToHead(T element)//adding node to d list
        {
            Node<T> node = new Node<T>(element);
            if(Head == null)
            {//if d head is null asign d created node to d head
                Head = node;
            }
            else
            {
                node.Next = Head;//new node.Next point to d head
                Head = node;
            }
            Count++;
        }

        public bool Remove(T element)//Remove node from d list
        { 
            Node<T> temp = Head;
            while(temp != null)
            {
                if (temp.Data.Equals(element))
                {
                    Head = temp.Next;       //temp = 1 
                                            //temp.next-> 2
                                            //temp.Next.Next = 3
                                            //temp.next.next.next = null
                    Count--;
                    return true;
                }
                else if(temp.Next != null)
                {
                    if (temp.Next.Data.Equals(element))
                    {
                        temp.Next = temp.Next.Next;
                        Count--;
                        return true;
                    }
                }
                temp = temp.Next;  
            }
            return false;
        }

        public bool Check(T element)
        {
            Node<T> temp = Head;
            while (temp != null)
            {
                if (temp.Data.Equals(element))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public int Index(T element)
        {
            Node<T> temp = Head;
            int count = 0;
            while (temp != null)
            {
                if (temp.Data.Equals(element))
                {
                    return count;
                }
                count++;
                temp = temp.Next;
            }
            return -1;
        }
        public void Print()
        {
            Node<T>? temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
