using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trees
{
    public class LowestCommonAncestor : IAlgorithm
    {
        public void Execute()
        {
            Node root = new Node(4);
            insert(root, 1);
            insert(root, 2);
            insert(root, 3);
            insert(root, 6);
            insert(root, 7);

            Node node = lca(root, 4, 6);
            Console.WriteLine("LCA: " + node.data);

        }

        private Node lca(Node root, int v1, int v2)
        {
            //Samller than both
            if (root.data < v1 && root.data < v2)
            {
                return lca(root.right, v1, v2);
            }
            //Bigger than both
            if (root.data > v1 && root.data > v2)
            {
                return lca(root.left, v1, v2);
            }

            //Else solution already found
            return root;

        }

        internal class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.data = data;
            }
        }

        static Node insert(Node root, int data)
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
    }

    

}
