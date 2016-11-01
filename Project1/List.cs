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
        public List()
        {
            head = null;
            tail = null;
        }

        public void Add(int value)
        {
            Element el = new Element(value);
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

        public bool Delete(int value)
        {
            Element current = head;
            Element before = null;

            if (head == null)
            {
                return false;
            }

            while (current != null && current.value != value)
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

        public void Show()
        {
            Element current = head;
            while (current != null)
            {
                Console.Write(current.value + " ");
                current = current.next;
            }
        }
    }
}
