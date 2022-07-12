using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Day_14
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public Node<T> tail;

        public void add(T data)
        {
            Node<T> addNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = addNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = addNode;
            }
            Console.WriteLine("{0} insert into Linked list", addNode.data);
        }


        public void append(T data)
        {
            Node<T> appendNode = new Node<T>(data);
            if (head == null)
            {
                head = appendNode;
                tail = appendNode;
            }
            else
            {
                tail.next = appendNode;
                tail = tail.next;
            }
        }
        public void RemoveFirst()
        {

            if (head == null)
            {
                return ;
            }
            head = head.next;
            return ;
        }

        public void RemoveLast()
        {
            Node<T> temp = head;
            if(head == null)
            {
                Console.WriteLine("LinkList is empty"); ;
            }
            else
            {
                while(temp.next != tail)
                {
                    temp = temp.next;
                }
                tail = temp.next;
                tail = temp;
            }



        }



        public void InsertBetween(T first, T second, T middle)
        {
            Node<T> newNode = new Node<T>(middle);
            Node<T> temp = head;
            while (temp.next != null)
            {
                if ((temp.data.Equals(first) && temp.next.data.Equals(second)) || (temp.data.Equals(second) && temp.next.data.Equals(first)))
                {
                    Node<T> after = temp.next;
                    temp.next = newNode;
                    temp.next.next = after;
                    break;

                }
                temp = temp.next;
            }

        }

        public bool search(T data)
        {
            Node<T> temp = head;
            bool isPresent = false;
            if(head ==null)
            {
                Console.WriteLine("Linklist is empty");
                return false;
            }
            else
            {
                while(temp != null)
                {
                    if (temp.data.Equals(data))
                    {
                        isPresent = true;
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }

            }
            return isPresent;

        }


        public void Display()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }

        }
    }
}