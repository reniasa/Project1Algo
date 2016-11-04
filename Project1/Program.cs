using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List();
            list1.Add(0, -1);
            list1.Add(-5, 2);
            list1.Add(6, 5);
            Show(list1);
            Console.WriteLine();

            List list2 = new List();
            list2.Add(0, -1);
            list2.Add(7, 2);
            list2.Add(4, 5);

            Show(list2);
            Console.WriteLine();

            List list3 = new List();
            List list4 = new List();
            PolynomialsOperations operation1 = new PolynomialsOperations();
            PolynomialsOperations operation2 = new PolynomialsOperations();
            list3 = operation1.Substraction(list1, list2);
            Show(list3);
            Console.WriteLine();
            list4 = operation2.Addition(list1, list2);
            Show(list4);
            list2.getLenght();
            
            Console.ReadKey();
        }

        private static void Show(List list)
        {
            Element current = list.head;
            while (current != null)
            {
                if (current.factor > 0)
                {
                    Console.Write("+" + current.factor + "x^" + current.index);
                }
                else
                {
                    Console.Write(current.factor + "x^" + current.index);
                }

                current = current.next;
            }
        }
    }
}
