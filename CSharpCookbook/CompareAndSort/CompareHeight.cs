using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook.CompareAndSort
{
    public class CompareHeight : IComparer<Square>
    {
        public int Compare(Square x, Square y)
        {
            if(x.Height == y.Height)
            {
                return 0;
            }
            else if(x.Height > y.Height)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
