using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Example
    {
        private string _word;
        private int _number;
        private bool _isValid;

        public Example(string word = "Unknown", int number = -1, bool isValid = true, char color = '0')
        {
            _word = word;
            _number = number;
            _isValid = isValid;
        }
    }   

    internal class Program
    {
        static void Main(string[] args)
        {
            Example e1 = new Example("aaa", 111, true);
            Example e2 = new Example("aaa", 111);
            Example e3 = new Example("aaa");
        }
    }


}   
