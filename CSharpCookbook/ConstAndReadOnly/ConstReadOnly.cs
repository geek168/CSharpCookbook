using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook.ConstAndReadOnly
{
    public class ConstReadOnly
    {
        
        //const 必须在声明时候赋值，因为它是在编译的时候就初始化好了值，被编译成了一个 static 的字段
        //const 还会存在组件引用的版本问题，此组件被其他组件引用之后，再次改变值新值不会替换旧值，因为他已经在把二进制的值编译到调用它的组件里；除非重新编译调用组件才会更新
        public const int x = 100;

        //readonly 就是运行时初始化的，在应用程序生命周期内是像 const 那样工作的
        public readonly int y = 200;

        public ConstReadOnly(int data)
        {
            y = data;
        }
    }
}
