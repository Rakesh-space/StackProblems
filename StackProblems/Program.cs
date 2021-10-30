using System;

namespace StackProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n UC2StackProblem.");
            UC2StackOperation stackProblem = new UC2StackOperation();
            stackProblem.push(56);
            stackProblem.push(30);
            stackProblem.push(70);
            stackProblem.peek();
            stackProblem.display();
            stackProblem.pop();
            stackProblem.isEmpty();
            stackProblem.display();
        }
    }
}
