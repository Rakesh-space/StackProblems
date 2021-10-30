using System;

namespace StackProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Stack operation :");
            UC1CreateStack st = new UC1CreateStack();
            st.push(56);
            st.push(30);
            st.push(70);
            st.display();
        }
    }
}
