using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    public abstract class LinkedList
    {
        public abstract NODE Head{ get; }

        public abstract void Pusp();
        public abstract void Pop();

        public bool IsEmpty()
        { 
            return Head == null;
        }

        public void Peek()
        {
            Console.WriteLine("Element to be poped is " + Head.Info);
        }

        public void Display()
        { 
            if (Head != null)
            {
                NODE cur = Head;
                while (cur != null)
                {
                    Console.WriteLine($"{cur.Info} -> ");
                    cur = cur.Next;
                }
            }
        }
    }
}
