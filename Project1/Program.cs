﻿using System;
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
            list1.Add(-5,4);
            list1.Add(6, 7);
            list1.Show();
            Console.WriteLine();

            List list2 = new List();
            list2.Add(0, -1);
            list2.Add(7, 4);
            list2.Add(8, 7);
            list2.Show();
            Console.WriteLine();

            PolynomialsOperations operation = new PolynomialsOperations();
            List list3 = operation.Addition(list1, list2);
            list3.Show();
            list2.getLenght();
            Console.ReadKey();
        }
    }
}
