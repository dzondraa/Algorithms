using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStrauctures.LinkedList
{
    public class MergeLinkedList : IAlgorithm
    {

        #region init
        public Node list1 =
            new Node(1,
                new Node(3,
                    new Node(5,
                        new Node(7, null))));

        public Node list2 =
            new Node(2,
                new Node(4,
                    new Node(6,
                        new Node(8, null))));


        public Node list3 =
            new Node(0,
                new Node(9,
                    new Node(10,
                        new Node(11, null))));

        #endregion

        public void Execute()
        {
            Merge(Merge(list1, list2).Next, list3);
        }

        // 1, | 3, 5
        // 2, 4, 6

        // 1, 2, 4, 6


        public static Node Merge(Node startNode1, Node startNode2)
        {
            Node dummy = new Node(-1, null);
            Node head = dummy;
            while (startNode1 != null && startNode2 != null)
            {
                if (startNode1.value < startNode2.value)
                {
                    dummy.Next = startNode1;
                    startNode1 = startNode1.Next;
                }

                else
                {
                    dummy.Next = startNode2;
                    startNode2 = startNode2.Next;

                }

                dummy = dummy.Next;

                if (startNode1 != null)
                    dummy.Next = startNode1;
                if (startNode2 != null)
                    dummy.Next = startNode2;

            }

            return head;
            
        }



    }

    public class Node
    {
        public int value
        {
            get; set;
        }

        public Node Next
        {
            get;
            set;
        }
        public Node(int value, Node next)
        {
            this.value = value;
            this.Next = next;
        }
    }

}

