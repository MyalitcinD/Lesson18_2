using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите строку скобок");
            string str = Console.ReadLine();

            Check(str);
            Console.ReadKey();
        }
        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('{', '}');
            dict.Add('[', ']');
            dict.Add('(', ')');
            dict.Add('<', '>');

            dict.Add('}', '0');
            dict.Add(']', '0');
            dict.Add(')', '0');
            dict.Add('>', '0');

            foreach(char ch in str) {

                if(dict[ch] != '0') {
                    stack.Push(dict[ch]);
                }
                else if((stack.Count != 0) && (ch == stack.Peek())) {
                    stack.Pop();
                }
                else { stack.Push('0'); break; }
            }

            if(stack.Count == 0) {
                Console.WriteLine("Последовательность корректна");
                return true;
            }
            else {
                Console.WriteLine("Последовательность некорректна");
                return false;
            }

        }

    }
}
