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
            TestMethod();
            Console.WriteLine();
            UserMethod();
        }

        private static void UserMethod()
        {
            List list1 = new List();
            list1.Add(0, -1);
            List list2 = new List();
            list2.Add(0, -1);
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Podaj ile chcesz argumentów " + i + " wielomianu: ");
                var firstArgumentsCount = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j <= firstArgumentsCount; j++)
                {
                    Console.Write("Podaj współczynnik " + j + " elementu: ");
                    var factor = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Podaj wykładnik " + j + " elementu: ");
                    var index = Convert.ToInt32(Console.ReadLine());
                    if (i == 1)
                    {
                        list1.Add(factor, index);
                    }
                    else
                    {
                        list2.Add(factor, index);
                    }

                }
                Console.WriteLine();
            }
            for (;;)
            {
                Console.WriteLine();
                Console.WriteLine("Wybierz działania: ");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Koniec");
                var expression = Convert.ToInt32(Console.ReadLine());

                switch (expression)
                {
                    case 1:
                        PolynomialsOperations operation1 = new PolynomialsOperations();
                        List list3 = operation1.Addition(list1, list2);

                        Show(list3);
                        break;
                    case 2:
                        PolynomialsOperations operation2 = new PolynomialsOperations();
                        List list4 = operation2.Substraction(list1, list2);
                        Console.WriteLine();
                        Show(list4);
                        break;
                    case 3:
                        PolynomialsOperations operation3 = new PolynomialsOperations();
                        List list5 = operation3.Multiplication(list1, list2);
                        Console.WriteLine();
                        Show(list5);
                        break;
                    default:
                        break;
                }
                if (expression == 4)
                {
                    break;
                }
            }
        }

        private static void TestMethod()
        {
            List list1 = new List();
            list1.Add(0, -1);
            list1.Add(-5, 2);
            list1.Add(6, 5);
            Console.Write("P(x) = ");
            Show(list1);
            Console.WriteLine();

            List list2 = new List();
            list2.Add(0, -1);
            list2.Add(7, 2);
            list2.Add(4, 5);
            Console.Write("Q(x) = ");
            Show(list2);
            Console.WriteLine();

            List list3 = new List();
            List list4 = new List();
            List list5 = new List();
            PolynomialsOperations operation1 = new PolynomialsOperations();
            PolynomialsOperations operation2 = new PolynomialsOperations();
            PolynomialsOperations operation3 = new PolynomialsOperations();

            list3 = operation1.Substraction(list1, list2);
            Console.Write("P(x) - Q(x) = ");
            Show(list3);
            Console.WriteLine();
            list4 = operation2.Addition(list1, list2);
            Console.Write("P(x) + Q(x) = ");
            Show(list4);
            Console.WriteLine();
            list5 = operation3.Multiplication(list1, list2);
            Console.Write("P(x) * Q(x) = ");
            Show(list5);
            Console.WriteLine();
            Console.WriteLine("Aby dodać własny wielomian naciśnij dowolny klawisz...");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Show(List list)
        {
            Element current = list.head;
            while (current != null)
            {
                if (current.factor >= 0 && current.index != -1)
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
