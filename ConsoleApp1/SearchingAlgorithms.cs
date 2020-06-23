using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SearchingAlgorithms
    {
        public static string BinarySerach(int[] arr, int value)
        {
            int Lift = 0;
            int Right = arr.Length - 1;
            int Mid;
            while (Right >= Lift)
            {
                Mid = (Right + Lift) / 2;
                if (arr[Mid] == value)
                {
                    return "Found!";
                }
                else if (arr[Mid] > value)
                {
                    Right = Mid - 1;
                }
                else
                {
                    Lift = Mid + 1;
                }
            }
            return "Not found!";
        }

    }
}
