﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My favorite color is Purple";

            Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));
        }
    }
}
