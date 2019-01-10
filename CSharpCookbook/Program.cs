using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(10, "");
            Console.ReadLine();
        }
    }

    struct Test
    {
        public int Age;
        public string Name;

        public Test(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
