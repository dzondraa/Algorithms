using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trees
{
    public class HeightofaBinaryTree : IAlgorithm
    {
        int[] nodes = new int[] { 2, 3, 5, 10, 17, 1, 8 };

        public void Execute()
        {
            // make a binary tree
            Node root = null;
            foreach(int data in nodes)
            {
                root = insert(root, data);
            }

            Console.WriteLine(traverse(root)); 
        }

        int traverse(Node node)
        {
            int res1 = 0;
            int res2 = 0;
            // Traverse left subtree if exists
            if (node.left != null)
            {
                res1++;
                res1 += traverse(node.left);
            }
            // Traverse right subtree if exists
            if (node.right != null)
            {
                res2++;
                res2 += traverse(node.right);
            }

            // Return longer subtree
            return Math.Max(res1, res2);
        }

        private Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        internal class Node
        {
            public Node left;
            public Node right;
            public int data;

            public Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }
    }


   
}
