using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems
{
    class UC2StackOperation
    {

        private Node top;  //Node type of top is variable 

        internal UC2StackOperation() //here constructor to initialize value to current instance top variable 
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
        internal void peek()  //To dislay the top of the stack
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is empty..");
                return;
            }
            Console.WriteLine("\n {0} is top of the stack. ", this.top.data); //To dislay the top of the stack
        }
  
        internal void pop()  //here delete the element into the top of the stack
        {
            if (this.top == null)
            {
                Console.WriteLine("\n Stack is Empty, Stack of top Not delete.");
                return;
            }
            Console.WriteLine("\n Data popped {0} in Stack of top. ", this.top.data); //actual popped data display
            this.top = this.top.next; //increment top of stack
        }

        internal bool isEmpty()  //here isEmpty() method use return boolean values
        {
            while(this.top!=null)
            {
                pop();
            }
            if (this.top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
