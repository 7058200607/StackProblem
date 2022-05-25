using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    public class StacksProblem
    {
        public Node top;
        public StacksProblem()  
        {
            this.top = null;

        }
        internal void push(int value) 
        {
            Node node = new Node(value);
            if(this.top != null) 
            {
                node.next = null;
            }
            else 
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed into stack", value);

           
        }
        internal void display() 
        {
            Node temp =this.top;
            while(temp != null) 
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}
