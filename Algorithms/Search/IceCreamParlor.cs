using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Search
{
    // The problem also known as - Two Sum problem
    public class IceCreamParlor : IAlgorithm
    {
        public void Execute()
        {
            int money = 5;
            List<int> cost = new List<int> { 2, 1, 3, 5, 6 };
            whatFlavors(cost, money);
        }

        public static void whatFlavors(List<int> cost, int money)
        {
            Dictionary<int,int> nums = new Dictionary<int,int>();
            
            for(int i = 0; i < cost.Count; i++) {
                if(!nums.ContainsKey(cost[i]))
                    nums.Add(cost[i], i);
            }
            
            for(int i = 0; i < cost.Count; i++)
                if(nums.ContainsKey(money - cost[i])
                && nums[money - cost[i]] != i)
                {
                    var first = ++nums[money - cost[i]];
                    var second = ++i;
                    var output = first < second ? $"{first} {second}" :
                    $"{second} {first}";
                    Console.WriteLine(output);
                    return;
                }        
        }

    }

    
}
