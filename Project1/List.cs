using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class List
    {
        public Element head;
        public Element tail;
        public int lenght; 
        public List()
        {
            head = null;
            tail = null;
            lenght = 0;
        }

        public void Add(int factor, int index)
        {
            Element el = new Element(factor, index);
            if(head == null)
            {
                head = tail = el;
            }
            else
            {
                tail.next = el;
                tail = el;
            }
        }

        public bool Remove(int factor, int index)
        {
            Element current = head;
            Element before = null;

            if (head == null)
            {
                return false;
            }

            while (current != null && current.factor != factor)
            {
                before = current;
                current = current.next;
            }

            if (current == null)
            {
                return false;
            }

            if(current == head)
            {
                head = current.next;
                return true;
            }

            if(current.next == null)
            {
                tail = before;
                before.next = null;
                return true;
            }

            before.next = current.next;
            return true;
        }

        

        public void GetLenght()
        {
            Element current = head;
            while (current != null)
            {
                lenght = lenght + 1;
                current = current.next;
            }
        }
    }
}
