using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStuctures.LinkedList
{
    public class CommonLinkedListProblems : IAlgorithm
    {
        public void Execute()
        {
            DoublyLinkedList llist = new DoublyLinkedList();
            llist.InsertNode(1);
            llist.InsertNode(2);
            llist.InsertNode(3);
            llist.InsertNode(4);
            llist.InsertNode(10);
            Console.WriteLine(hasCycle(llist.head));
            PrintDoublyLinkedList(insertNodeAtPosition(llist.head, 123, 2), "<->");
        }

        /// <summary>
        /// Inserts node at the specific position
        /// </summary>
        /// <param name="position">Position int starting from 0</param>
        /// <returns>Head of reversed list</returns>
        static DoublyLinkedListNode insertNodeAtPosition(DoublyLinkedListNode llist, int data, int position)
        {
            var current = llist;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.next;
            }

            var insertionNode = new DoublyLinkedListNode(data);
            insertionNode.next = current.next;
            current.next = insertionNode;


            return llist;

        }

        /// <summary>
        /// Reverses doubly linked list
        /// </summary>
        /// <param name="curr">Head of a list</param>
        /// <returns>Head of reversed list</returns>
        static DoublyLinkedListNode Reverse(DoublyLinkedListNode curr)
        {
            DoublyLinkedListNode temp = curr.next;
            curr.next = curr.prev;
            curr.prev = temp;
            return temp == null ? curr : Reverse(temp);
        }


        /// <summary>
        /// Inser the value in a sorted manner
        /// </summary>
        /// <returns>Head of reversed list</returns>
        static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
        {
            var insertionNode = new DoublyLinkedListNode(data);

            if (llist == null) return insertionNode;

            if (data <= llist.data)
            {
                llist.prev = insertionNode;
                insertionNode.next = llist;
                return insertionNode;
            }

            else 
            {
                DoublyLinkedListNode rest = sortedInsert(llist.next, data);
                llist.next = rest;
                rest.prev = llist;
                return llist;
            }
        }

        /// <summary>
        /// Check if list conains cycles
        /// </summary>
        /// <param name="head">Head of a linked list</param>
        /// <returns>True if there is cycle</returns>
        static bool hasCycle(DoublyLinkedListNode head)
        {
            List<DoublyLinkedListNode> visited = new List<DoublyLinkedListNode>();
            while (head != null)
            {
                if (visited.Contains(head))
                    return true;

                visited.Add(head);
                head = head.next;
            }
            return false;
        }

        /// <summary>
        /// Finding the node where 2 linked lists are merged
        /// </summary>
        /// <param name="head1">Head of first linked list</param>
        /// <param name="head2">Head of second linked list</param>
        /// <returns>Data value of merge node </returns>
        static int findMergeNode(DoublyLinkedListNode head1, DoublyLinkedListNode head2)
        {
            while (head2 != null)
            {

                var headCLone = head1;
                while (headCLone != null)
                {
                    if (headCLone == head2)
                        return headCLone.data;
                    headCLone = headCLone.next;
                }

                head2 = head2.next;
            }
            return 0;

        }

        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }
    }
}
