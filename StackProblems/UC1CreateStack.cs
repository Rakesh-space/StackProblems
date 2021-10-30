using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class UC1CreateStack
    {
        private Node top;  //Node type of top is variable 

        internal UC1CreateStack() //here constructor to initialize value to current instance top variable 
        {
            this.top = null;
        }
        internal void push(int data) //pushing the value into top of the stack
        {
            Node newNode = new Node(data);  //here newNode is created and to occuepied the memory and store the data
            if (this.top == null)
            {
                newNode.next = this.top;  //newNode point to the top of the stack
            }
            this.top = newNode;  //newNode to assigned to the top of stack
            Console.WriteLine(" {0} push to stack ", data);
        }
        internal void display()  //display the all stack of the data
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " "); //actual display the data in  stack of top
                temp = temp.next;
            }
        }
    }
}
