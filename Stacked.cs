using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    public class Stacked : LinkedListed
    {
        public override void Pusp(int data)
        {
            if (IsEmpty())
            { 
                Head = new NODE(data);
            }
            else
            {
                NODE newNode = new NODE(data);
                newNode.Next = Head;
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
