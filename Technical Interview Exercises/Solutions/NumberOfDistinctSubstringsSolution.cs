using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Interview_Exercises
{
    public class DisctinctSubstringsSolution
    {
        /*
        Given a string, count all distinct substrings of the given string.

        Examples: 

        Input : abcd
        Output : abcd abc ab a bcd bc b cd c d
        All Elements are Distinct

        Input : aaa
        Output : aaa aa a aa a a
        All elements are not Distinct
        */


        public static int DistinctSubstrings(string str)
        {
            HashSet<string> result = new HashSet<string>();

            for(int i = 0; i <= str.Length; i++)
            {
                for(int j = i + 1; j <= str.Length; j++)
                {
                    result.Add(str.Substring(i, j - i));
                }
            }
            
            return result.Count;
            
        }






    }
}
