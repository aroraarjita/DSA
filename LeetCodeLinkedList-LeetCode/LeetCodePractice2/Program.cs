//using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace LeetCodePractice2
{
  class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        }
        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.next = null;

            return temp;
        }
        static int countOfNodes(Node head)
        {
            int count = 0;

            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Node head = newNode(1);
            head.next = newNode(2);
            head.next.next = newNode(3);
            head.next.next.next = newNode(4);

            printList(head);
            head = DeleteMiddle(head);
            printList(head);

            Console.Read();
            //LinkedList<int> integerList = new LinkedList<int>(new[] { 1, 3, 4, 7, 1, 2, 6 });
            //LinkedListNode<int> linkedListNode = DeleteMiddle(integerList.First);

        }
        public static Node DeleteMiddle(Node head)
        {
            int count = countOfNodes(head);


            if (head.next == null)
                return null;
            else if (head.next == null)
                return null;

            Node linkedListNode = head;

          

            int middleNext = count / 2;

            for (int i = 0; i < middleNext-1; i++)
                linkedListNode = linkedListNode.next;


            linkedListNode.next = linkedListNode.next.next;
            return head;

        }

        public static void printList(Node node)
        {
            while(node != null)
            {
                Console.Write(node.data + "->");
                node = node.next;

            }

            Console.WriteLine("NULL");
        }
    }


}
