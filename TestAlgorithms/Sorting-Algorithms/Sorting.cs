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
				if (arr[i] < pivot)	leftArr.Add(arr[i]);
			    else rightArr.Add(arr[i]);
			}

			var leftSorted = QuickSort(leftArr.ToArray());
			var rightSorted = QuickSort(rightArr.ToArray());

			var newArr = new List<int>();

			newArr.AddRange(leftSorted);
			newArr.Add(pivot);
			newArr.AddRange(rightSorted);

			return newArr.ToArray();
		}

		public static int[] MergeSort(int[] arr)
		{
			if (arr.Length < 2) return arr;

			int midIndex = arr.Length / 2;
			var leftArr = new int[midIndex];
			var rightArr = new int[arr.Length - midIndex];
			Array.Copy(arr, 0, leftArr, 0, midIndex);
			Array.Copy(arr, midIndex, rightArr, 0, arr.Length - midIndex);

			return Merge(leftArr, rightArr);
		}

		private static int[] Merge(int[] leftArr, int[] rightArr)
		{
			var resultArr = new List<int>();
			var leftIndex = 0;
			var rightIndex = 0;

			while(leftIndex < leftArr.Length && rightIndex < rightArr.Length)
			{
				if(leftArr[leftIndex] < rightArr[rightIndex])
				{
					resultArr.Add(leftArr[leftIndex]);
					leftIndex++;
				}else
				{
					resultArr.Add(rightArr[rightIndex]);
					rightIndex++;
				}
			}

			return new int[3];
		}

		public static bool BinarySearch(int[] arr, int start, int end, int target)
		{
			if (start > end) return false;
			int midIndex =(start + end) / 2;

			if (arr[midIndex] == target) return true;

			if (arr[midIndex] > target) return BinarySearch(arr, start, midIndex - 1, target);
			else return BinarySearch(arr, midIndex + 1, end, target);
		}

		public static int[] MyQuickSort(int[] arr)
		{
			if (arr.Length < 1) return arr;

			var pivot = arr[arr.Length - 1];
			var leftArr = new List<int>();
			var rightArr = new List<int>();

			for(int i = 0; i < arr.Length-1; i++)
			{
				if (arr[i] < pivot) leftArr.Add(arr[i]);
				else rightArr.Add(arr[i]);
			}

			var leftSorted = MyQuickSort(leftArr.ToArray());
			var rightSorted = MyQuickSort(rightArr.ToArray());

			var newArr = new List<int>();

			newArr.AddRange(leftSorted);
			newArr.Add(pivot);
			newArr.AddRange(rightSorted);

			return newArr.ToArray();
		}

		public static int[] BubbleSort(int[] arr)
		{
			for (int partIndex = arr.Length-1; partIndex > 0; partIndex--)
			{
				for(int i = 0; i < partIndex; i++)
				{
					if(arr[i] > arr[i + 1])
					{
						var temp = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = temp;
					}
				}
			}

			return arr;
		}
	}
}
