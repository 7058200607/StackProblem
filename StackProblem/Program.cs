﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    public class program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Do Stack Operation!");
            StacksProblem stacksProblem = new StacksProblem();
            stacksProblem.push(70);
            stacksProblem.push(30);
            stacksProblem.push(56);
            stacksProblem.display();
           stacksProblem.peek();
           stacksProblem.display();
            stacksProblem.pop();
            stacksProblem.display();
            stacksProblem.IsEmpty();
            stacksProblem.display();
        }


    }
}
