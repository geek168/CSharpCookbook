using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCookbook.CompareAndSort
{
    public class Square : IComparable<Square>
    {
        public Square()
        {

        }

        public Square(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }

        public int Width { get; set; }

        public override string ToString() => $"Heigth:{Height}，Width:{Width}，Square:{ Height * Width}";

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            var other = obj as Square;
            if(other == null)
            {
                return false;
            }

            return CompareTo(other) == 0;
        }

        /// <summary>
        /// 重载 Equals 方法一定要重载 GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Height.GetHashCode() | Width.GetHashCode();
        }

        public int CompareTo(Square other)
        {
            int area = Width * Height;
            int area_other = other.Width * other.Height;
            if(area == area_other)
            {
                return 0;
            }
            else if(area > area_other)
            {
                return 1;
            }
            else if(area < area_other)
            {
                return -1;
            }
            else
            {
                return -1;
            }
        }
    }
}
