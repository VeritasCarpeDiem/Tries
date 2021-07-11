using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tries
{
    public static class Extensions
    {
        public static int[] SelectDemo(this string[] arr)
        {
            int[] intArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                intArr[i] = int.Parse(arr[i]);
            }

            return intArr;
        }

       
    }
}
