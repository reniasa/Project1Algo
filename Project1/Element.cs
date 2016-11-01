using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Element
    {
        public int value;
        public Element next;
        public Element(int val)
        {
            value = val;
            next = null;
        }
    }
}
