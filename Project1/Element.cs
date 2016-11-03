using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Element
    {
        public int factor;
        public int index;
        public Element next;
        public Element(int fac, int i)
        {
            factor = fac;
            index = i;
            next = null;
        }
    }
}
