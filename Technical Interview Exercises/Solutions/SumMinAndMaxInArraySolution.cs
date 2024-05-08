using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Interview_Exercises
{
    public class SumMinAndMaxInArraySolution
    {
        /*
        Given an array, write functions to find the minimum and maximum elements in it, and calculate
        the sum of those elements. 
        */


        public static int SumOfMinAndMax(int[] arr)
        {
            Array.Sort(arr);

            return arr[0] + arr[arr.Length - 1];
            
        }






    }
}
