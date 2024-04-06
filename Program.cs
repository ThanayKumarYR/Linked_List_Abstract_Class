using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implememntation of stack via abstract Linked List !");
            //stack implimentation.
            Stacked stacked = new Stacked();
            //adding element to stack via methode Push().
            stacked.Pusp(10);
            stacked.Pusp(11);
            //Displaying the stack elements.
            stacked.Display();

            stacked.Pusp(12);
            stacked.Pusp(13);
            stacked.Pusp(14);
            stacked.Pusp(15);

            stacked.Display();
            //deleting the element on top of the stack
            stacked.Pop();

            stacked.Display();

            stacked.Pop();
            stacked.Pop();

            stacked.Display();

            //Peek() returns the element in the top of stack.
            int topElement = stacked.Peek();

            Console.WriteLine($"Peek() : Top of the stack = {topElement}");
        }
    }
}
