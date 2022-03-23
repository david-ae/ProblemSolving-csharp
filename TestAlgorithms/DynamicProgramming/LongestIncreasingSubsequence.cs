using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsNDatastructures.DynamicProgramming
{
    public class LongestIncreasingSubsequence
    {

        Dictionary<int, int> memo = new Dictionary<int, int>();
        int newIndex = 0;
        public Dictionary<int, int> LongestIS(int[] arr)
		{
            int index = 0;            
            for (int i = newIndex; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    index++;
                }
                else
                {
                    memo[newIndex] = index;
                    newIndex = i + 1;
                    LongestIS(arr);
                }
            }

            var result = memo.Values.Max();

            return memo;
        }
    }
}
