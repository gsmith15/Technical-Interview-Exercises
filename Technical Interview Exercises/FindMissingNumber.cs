using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Interview_Exercises
{
    public class FindMissingNumber
    {
        /*
        Given an array arr[] of size N-1 with integers in the range of[1, N], 
        the task is to find the missing number from the first N integers.

        Note: There are no duplicates in the list.

        Input: arr[] = { 1, 2, 4, 6, 3, 7, 8} , N = 8
        Output: 5
        Explanation: Here the size of the array is 8, so the range will be[1, 8]. 
        The missing number between 1 to 8 is 5
        */


        public static int missingNumber(int[] arr, int N)
        {
            int[] temp = new int[N + 1];

            for(int i = 0; i < N-1; i++) 
            {
                temp[arr[i] - 1] = 1;
            
            }

            int missingNum = 0;

            for(int i = 0; i <=N; i++) 
            {
                if (temp[i] == 0)
                {
                    missingNum = i + 1;
                }
            }

            return missingNum;
        }






    }
}
