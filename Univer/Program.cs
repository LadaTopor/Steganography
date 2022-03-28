using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<char, char> skob = new Dictionary<char, char>()
        {
            { ']', '[' },
            { '}', '{' },
            { ')', '(' }
        };
            Stack<char> brothers = new Stack<char>();
            string n = Console.ReadLine();

            foreach (char c in n)
            {
                if (skob.ContainsValue(c))
                {
                    brothers.Push(c);
                }
                else
                {
                    if (skob[brothers.Peek()])
                    
                    if (brothers.Count == 0)
                    {
                    }
                    else { 
                        brothers.Pop();
                    }
                }
            }
            Console.WriteLine("YES");
            Console.WriteLine("NO");
        }
    }
}
