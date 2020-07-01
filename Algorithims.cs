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
