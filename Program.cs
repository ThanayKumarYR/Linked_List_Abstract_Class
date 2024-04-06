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

            if (topElement != -999)
                Console.WriteLine($"Peek() : Top of the stack = {topElement}");
            else Console.WriteLine("Stack is empty !");

            Console.WriteLine();
            Console.WriteLine("Implementation of Queues !");
            //Creating the Queue.
            Queued queued = new Queued();

            //Displays queue
            queued.Display();

            //Gets the first element of queue
            int first = queued.Peek();
            if(first != -999)
            Console.WriteLine("Peek() : First of the Queue = " + first);
            else Console.WriteLine("Queue is empty !");

            //Adding the elements in the rare.
            queued.Pusp(1);
            queued.Pusp(2);
            queued.Pusp(3);
            queued.Pusp(4);
            queued.Pusp(5);

            queued.Display();

            //Deleting the elements at the front.
            queued.Pop();

            queued.Display();

            queued.Pop();
            queued.Pop();

            queued.Display();

            int first1 = queued.Peek();
            if (first1 != -999)
                Console.WriteLine("Peek() : First of the Queue = " + first1);
            else Console.WriteLine("Queue is empty !");

        }
    }
}
