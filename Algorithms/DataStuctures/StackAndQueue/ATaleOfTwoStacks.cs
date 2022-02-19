using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.DataStuctures.StackAndQueue
{
    class ATaleOfTwoStacks : IAlgorithm
    {
        public void Execute()
        {
            var input = new List<List<int>> {
                new List<int> { 1, 15 },
                new List<int> { 1, 17 },
                new List<int> { 3 },
                new List<int> { 1, 25 },
                new List<int> { 2 },
                new List<int> { 3 },
                new List<int> { 2 },
                new List<int> { 3 },
            };
            var queue = new MyQueue();
            var results = new List<int>();

            foreach(var query in input)
            {
                if(query[0] == 1)
                {
                    queue.Enqueue(query[1]);
                }
                if (query[0] == 2)
                {
                    queue.Dequeue();
                }
                if (query[0] == 3)
                {
                    results.Add(queue.Peek());
                }
            }
            
            foreach(var res in results)
            {
                Console.WriteLine(res);
            }
        }

        class MyQueue
        {

            private Stack<int> bufferStack = new Stack<int>();
            private Stack<int> dataStack = new Stack<int>();

            public void Enqueue(int input)
            {
                bufferStack.Push(input);  
            }

            public int Dequeue()
            {
                if (dataStack.Count == 0)
                    FillDataStack();
                return dataStack.Pop();
            }

            public int Peek()
            {
                if (dataStack.Count == 0)
                    FillDataStack();
                return dataStack.Peek();
            }

            // This is the key of optimization.
            // If buffer stack is not empty, we can still use it as it is in good state
            // we will refill it only if empty, by poping all the elements from data stack
            private void FillDataStack()
            {
                while (bufferStack.Count != 0)
                    dataStack.Push(bufferStack.Pop());
            }
        }
    }
}
