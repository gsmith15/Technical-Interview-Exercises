using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Interview_Exercises
{
    public class Largest_Sum_Subarray_Solution
    {
        /*Largest Sum Contiguous Subarray
        Given an array arr[] of size N, find the sum of the contiguous subarray within an arr[] with the largest sum. 

        Example:

        Input: arr = { -2,-3,4,-1,-2,1,5,-3}
        Output: 7
        Explanation: The subarray { 4,-1, -2, 1, 5}
        has the largest sum 7.
        */

        public static int maxSubArraySum(int[] arr)
        {
            int max_arr = int.MinValue, max_ending_here = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if(max_arr < max_ending_here)
                {
                    max_arr = max_ending_here;
                }
                if(max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
            }
            return max_arr;
        }

    }
}
