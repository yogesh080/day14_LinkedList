using System;
using System.Collections.Generic;
using System.Text;

namespace LinkListU
{

    public class LinkList
    {
        internal Node head;

        // Adding number to a linkedList
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} interted into linked list", node.data);

        }
        //For Display
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linklist is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+"");
                temp = temp.next;
            }
        }
    }
}