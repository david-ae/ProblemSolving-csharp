using AlgorithmsNDatastructures.DynamicProgramming;
using System;
using System.Collections.Generic;
using TestAlgorithms.Algorithms;
using TestAlgorithms.BinaryTree;
using TestAlgorithms.DynamicProgramming;
using TestAlgorithms.Graph;

namespace TestAlgorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			//var result = Sorting.QuickSort(new int[] { 10, 17, 14, 20, 21, 22, 7, 8, 8, 5 });
			LongestIncreasingSubsequence seq = new LongestIncreasingSubsequence();
			var result = Sorting.BubbleSort(new int[] { 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8, 10, 17, 14, 20, 21, 22, 7, 8, 8, 5, 4, 20, 21, 20, 21, 22, 7, 8 });
			//var numbers = new int[] { 70, 17, 24, 20, 21, 22, 7, 8, 8, 5 };
			//Sorting.BinarySearch(numbers, 0, numbers.Length-1, 3);
			//var arr = Sorting.MergeSort(numbers);
			//Console.WriteLine(Fibonnaci.Fib(7));

			//var a = new Node("a");
			//var b = new Node("b");
			//var c = new Node("c");
			//var d = new Node("d");
			//var e = new Node("e");
			//var f = new Node("f");

			var a = new Node(20);
			var b = new Node(4);
			var c = new Node(8);
			var d = new Node(5);
			var e = new Node(1);
			var f = new Node(9);

			a.left = b;
			a.right = c;
			b.left = d;
			b.right = e;
			c.right = f;

			TreeProblems treeProblems = new TreeProblems();
			//treeProblems.DepthFirstValues(a);
			//var result = treeProblems.RecursiveDepthFirstValues(a);
			//var result = treeProblems.BreadthFirstValues(a);
			//var result = treeProblems.RecursiveTreeIncludes(a, "z");
			//var result = treeProblems.TreeSumDepthFirst(a);
			//var result = treeProblems.TreeSumBreadthFirst(a);
			//var result = treeProblems.TreeSumRecursive(a);
			//var result = treeProblems.RecursiveTreeMin(a);

			Dictionary<string, string[]> graph = new Dictionary<string, string[]>();
			//graph["a"] = new string[] {"b", "c"};
			//graph["b"] = new string[] { "d" };
			//graph["c"] = new string[] { "e" };
			//graph["d"] = new string[] { "f" };
			//graph["e"] = new string[] {};
			//graph["f"] = new string[] {};

			graph["f"] = new string[] { "g", "i" };
			graph["g"] = new string[] { "h" };
			graph["h"] = new string[] { };
			graph["i"] = new string[] { "g", "k" };
			graph["j"] = new string[] { "i" };
			graph["k"] = new string[] { };

			Graphs graphObject = new Graphs();
			//graphObject.DepthFirst(graph, "a");
			//graphObject.RecursiveDepthFirst(graph, "a");
			Console.WriteLine(graphObject.HasPathBreadthFirst(graph, "j", "i"));
		}
	}
}
