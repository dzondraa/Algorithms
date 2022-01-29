using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trees
{
    class IsThisABinarySearchTree : IAlgorithm
    {
        public void Execute()
        {
            Node root = new Node(3);
            root.Left = new Node(2);
            root.Left.Left = new Node(1);
            root.Right = new Node(5);
            root.Right.Left = new Node(6);
            root.Right.Right = new Node(1);

            Console.WriteLine(checkBST(root));

        }


        static bool checkBST(Node root)
        {
            if (root != null) 
            {
                if (root.Data >= root.Right.Data || root.Data <= root.Left.Data)
                    return false;
                return checkBST(root.Right) && checkBST(root.Left);
            }
            return true;
        }

        internal class Node
        {
            public int Data { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int data)
            {
                Data = data;
            }
        }
    }
}
