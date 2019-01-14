using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpCookbook.Comparable;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Square> list = new List<Square>
            {
                new Square(3,4),
                new Square(4,5),
                new Square(2,1)
            };
            list.Sort();
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("-----------------");

            SortedList<int, Square> sortlist = new SortedList<int, Square>()
            {
                { 0, new Square(1,3) },
                { 2, new Square(3,3) },
                { 1, new Square(2,1) },
                { 3, new Square(6,1) }
            };
            foreach(var s in sortlist)
            {
                Console.WriteLine($"{s.Key} : {s.Value}");
            }

            Console.WriteLine("-----------------");

            List<Square> list1 = new List<Square>
            {
                new Square(3,4),
                new Square(4,5),
                new Square(2,1)
            };
            list1.Sort(new CompareHeight());
            foreach (var s in list1)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
