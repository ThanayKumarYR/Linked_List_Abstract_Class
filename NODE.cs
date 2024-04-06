using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LinkedList
{
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
