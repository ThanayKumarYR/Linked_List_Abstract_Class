﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    //Linked List is the collection of nodes used for efficient memory management.
    public abstract class LinkedListed<T>
    {
        protected NODE<T> Head{ get; set; } = null;

        //Abstact methodes needs implementation from derived class.
        public abstract void Pusp(T data);
        public abstract void Pop();

        /*
          Non - Abstarct methode, can only be used by derived class,
          after the providing implimentation to all abstarct mthodes 
        */

        //Checks if Linked List is empty or not ?
        public bool IsEmpty()
        { 
            return Head == null;
        }

        //Returns the data of head node.
        public T Peek()
        {
            if (!IsEmpty())
                return Head.Info;
            else throw new ApplicationException("It is empty !");
        }

        //Displays the Linked List.
        public virtual void Display()
        { 
            if (!IsEmpty())
            {
                NODE<T> cur = Head;
                Console.Write("Head = ");
                while (cur != null)
                {
                    Console.Write($"{cur.Info} -> ");
                    cur = cur.Next;
                }
                Console.WriteLine("null.");
            }
            else 
            {
                Console.WriteLine("It is empty !");
            }
        }
    }
}
