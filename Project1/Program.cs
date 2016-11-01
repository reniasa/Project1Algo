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
            List list = new List();
            list.Add(5);
            list.Add(10);
            list.Add(34);
            list.Add(234);
            list.Add(556);
            list.Add(54);
            list.Delete(34);
            list.Show();
            Console.ReadKey();
        }
    }
}
