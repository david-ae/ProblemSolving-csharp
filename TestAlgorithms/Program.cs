using System;
using TestAlgorithms.Algorithms;
using TestAlgorithms.BinaryTree;
using TestAlgorithms.DynamicProgramming;

namespace TestAlgorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Sorting.QuickSort(new int[] { 10, 17, 14, 20, 21, 22, 7, 8, 8, 5 });
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
			var result = treeProblems.RecursiveTreeMin(a);
		}
	}
}
