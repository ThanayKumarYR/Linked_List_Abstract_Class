using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    public class Stacked<T> : LinkedListed<T>
    {
        public override void Pusp(T data)
        {
            if (IsEmpty())
            { 
                Head = new NODE<T>(data);
            }
            else
            {
                NODE<T> newNode = new NODE<T>(data)
                {
                    Next = Head
                };
                Head = newNode;
            }

        }

        public override void Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Deleting the top of the stack containg data = " + Peek());
                Head = Head.Next;
            }
            else 
            {
                Console.WriteLine("Stack is empty");
            }
        }
    }
}
