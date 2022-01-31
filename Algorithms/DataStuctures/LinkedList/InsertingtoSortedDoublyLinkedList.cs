using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStuctures.LinkedList
{
    public class InsertingtoSortedDoublyLinkedList : IAlgorithm
    {
        public void Execute()
        {
            DoublyLinkedList llist = new DoublyLinkedList();
            llist.InsertNode(1);
            llist.InsertNode(2);
            llist.InsertNode(3);
            llist.InsertNode(4);
            llist.InsertNode(10);
            PrintDoublyLinkedList(sortedInsert(llist.head, 5), "<->");
        }

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
