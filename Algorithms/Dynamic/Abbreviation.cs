using Algorithms.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Algorithms.Dynamic
{
    class Abbreviation : IAlgorithm
    {

        private bool isPossible = false;
        private Dictionary<string, bool> memo = new Dictionary<string, bool>();
        private string abbreviation(string a, string b)
        {
            isPossible = false;
            memo.Clear();
            rec(a, b);
            return isPossible ? "YES" : "NO";
        }
        
        private void rec(string a, string b) {
            if(isPossible || a.Length < b.Length) return; 
            if(b.Length == 0) {
                if(a.All(char.IsLower))
                    isPossible = true;    
                return;
            }
            
            if(memo.ContainsKey(a + "#" + b)) return;
            memo.Add(a + "#" + b, true);
        
        var fc = a[a.Length - 1];
        a = a.Remove(a.Length - 1, 1);  
        if(Char.IsLower(fc)) rec(a, b);
        if(char.ToUpper(fc) != b[b.Length - 1]) return;
        b = b.Remove(b.Length - 1, 1);  
        rec(a,b);
        
        
        return;
        
        }
        // PROBLEM: https://www.hackerrank.com/challenges/crossword-puzzle/problem
        public void Execute()
        {
            string a = "AbcDE";
            string b = "ABDE";
            Console.WriteLine(this.abbreviation(a,b));
        }
    }

}
