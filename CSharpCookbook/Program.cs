﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCookbook.CompareAndSort;
using CSharpCookbook.ConstAndReadOnly;
using CSharpCookbook.ICloneable;

namespace CSharpCookbook
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortSquare.TestSort();

            //var v = new ConstReadOnly(300);
            //Console.WriteLine(ClassLibrary.Foo.x);

            CloneableTest cloneableTest = new CloneableTest();
            cloneableTest.Test();

            Console.ReadLine();
        }
    }
}
