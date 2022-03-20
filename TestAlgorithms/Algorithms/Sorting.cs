using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithms.Algorithms
{
	public class Sorting
	{
		public static int[] QuickSort(int[] arr)
		{
			if (arr.Length < 1) return arr;

			var pivot = arr[arr.Length - 1];
			var leftArr = new List<int>();
			var rightArr = new List<int>();

			for (var i = 0; i < arr.Length - 1; i++)
			{
				if (arr[i] < pivot)
				{
					leftArr.Add(arr[i]);
				}
				else
				{
					rightArr.Add(arr[i]);
				}
			}

			var newArr = new List<int>();

			newArr.AddRange(leftArr);
			newArr.Add(pivot);
			newArr.AddRange(rightArr);

			for(var i = 0; i < newArr.Count-1; i++)
			{
				Console.Write(newArr[i] + ",");
				if(i == newArr.Count)
				{
					Console.WriteLine();
					break;
				}
			}

			return QuickSort(newArr.ToArray());
		}
	}
}
