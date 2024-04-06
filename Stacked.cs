using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    public class Stacked : LinkedList
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
            Console.WriteLine("Deleting the top of the stack containg data = " + Peek());
            Head = Head.Next;
        }
    }
}
