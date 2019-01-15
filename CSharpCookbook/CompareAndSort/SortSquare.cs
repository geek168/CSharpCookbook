using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook.CompareAndSort
{
    public class SortSquare
    {
        public static void TestSort()
        {
            List<Square> list = new List<Square>
            {
                new Square(3, 4),
                new Square(4, 5),
                new Square(2, 1),
                new Square(3, 3)
            };
            Console.WriteLine("------Original list being---------");
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------Original list end---------");
            Console.WriteLine();

            list.Sort();
            Console.WriteLine("------Sorted And Search list using IComparable being---------");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            var t = list.BinarySearch(new Square(2, 1));
            Console.WriteLine($"Found (2, 1) in : {t}");
            Console.WriteLine("------Sorted And Search list using IComparable end---------");
            Console.WriteLine();

            IComparer<Square> comparer = new CompareHeight();
            list.Sort(comparer);
            Console.WriteLine("------Sorted And Search list using IComparer being---------");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
            t = list.BinarySearch(new Square(4, 5), comparer);
            Console.WriteLine($"Found (4, 5) in : {t}");
            Console.WriteLine("------Sorted And Search list using IComparer end---------");
            Console.WriteLine();

            SortedList<int, Square> sortlist = new SortedList<int, Square>()
            {
                {0, new Square(1, 3) },
                {2, new Square(4, 3) },
                {1, new Square(2, 1) },
                {4, new Square(6, 1) }
            };
            Console.WriteLine("------Sorted And Search list using SortedList being---------");
            foreach (var s in sortlist)
            {
                Console.WriteLine($"{s.Key} {s.Value}");
            }
            var tt = sortlist.ContainsKey(2);
            Console.WriteLine($"Found key 2 : {tt}");

            /*
             *  如果未重载 Square 的 Equals 方法，这个会按照默认的对象比对，所以输出是 false
             *  并且ContainValue 是按照线性查找来的，其他上面的所有都是按照 Binary Search 进行的
             */
            tt = sortlist.ContainsValue(new Square(2, 1));

            Console.WriteLine($"Found (2, 1) : {tt}"); 
            Console.WriteLine("------Sorted And Search list using SortedList end---------");
        }

    }
}
