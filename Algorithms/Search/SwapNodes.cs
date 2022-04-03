using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    // The problem also known as - Two Sum problem
    public class SwapNodes : IAlgorithm
    {
        public void Execute()
        {
            var indexes = new List<List<int>> {
              new List<int> { 2, 3 },
              new List<int> { -1, -1 },
              new List<int> { -1, -1 }
            };
            var queries = new List<int> {2, 1, 1};
            foreach(var l in swapNodes(indexes, queries)) {
                Console.WriteLine("-------------------");
                foreach(int num in l) Console.Write($"{num} ");
                Console.WriteLine();
            }  
        }

        public class Node {
            public int info;
            public Node left;
            public Node right;
            public Node(int info) {
                this.info = info;
            }
        }
    
        public static void swap(Node root, int k, int level, List<int> l) {
            if(root != null) {
                if(level % k == 0) {
                    var tmp = root.left;
                    root.left = root.right;
                    root.right = tmp;
                }
                
                swap(root.left, k, level + 1, l);
                l.Add(root.info);
                swap(root.right, k, level + 1, l);
            }
        }
        
        public static List<List<int>> swapNodes(List<List<int>> indexes, List<int> queries)
        {
            List<List<int>> result = new List<List<int>>();
            var root = buildTree(indexes);
            
            foreach(var k in queries) {
                var iterrationRes = new List<int>();
                swap(root, k, 1, iterrationRes);
                result.Add(iterrationRes);
            }
            
            return result;
            
        }
        
        public static Node buildTree(List<List<int>> indexes) {
            Queue<Node> q = new Queue<Node>();
            Node root = new Node(1);
            q.Enqueue(root);
            
            foreach(var indexPair in indexes) {
                var temp = q.Dequeue();
                if(indexPair[0] != -1) {
                    temp.left = new Node(indexPair[0]);
                    q.Enqueue(temp.left);
                }
                if(indexPair[1] != -1) {
                    temp.right = new Node(indexPair[1]);
                    q.Enqueue(temp.right);
                }
            }
            
            return root;
            
        }
    }

    

    
}
