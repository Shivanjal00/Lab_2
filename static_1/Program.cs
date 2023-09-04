using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_1
{
    static class mathHelper
    {
        public static void calc(int[] arr)
        {
            int l = arr.Length;
            int sum = 0;
            for (int i = 0; i < l; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum / l);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            mathHelper.calc(ar);
        }
    }
}