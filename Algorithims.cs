using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Program
    {
        static void Main(string [] args)
        {
            //ToDo
        }
    }

    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            //stopped here tues
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
    }


    public class Node 
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" +data+ ">");
        }
    }
}
