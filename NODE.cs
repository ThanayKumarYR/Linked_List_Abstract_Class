using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
    //Node is the single unit of Linked List to store the data and reference to next node.
    public class NODE
    {
        public int Info { get; set; }
        public NODE Next { get; set; }
        public NODE(int data) 
        {
            Info = data;    
            Next = null;
        }   
    }
}
