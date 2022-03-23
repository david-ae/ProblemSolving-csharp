using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithms.BinaryTree
{
	public class TreeProblems
	{
		// iterative version
		public IEnumerable<string> DepthFirstValues(Node root)
		{
			if (root == null) return new List<string>();
			var result = new List<string>();
			Stack<Node> stack = new Stack<Node>();
			stack.Push(root);

			while(stack.Count > 0)
			{
				var current = stack.Pop();

				result.Add(current.value);

				if (current.right != null) stack.Push(current.right);
				if (current.left != null) stack.Push(current.left);				
			}

			return result;
		}

		// recursive version
		public IEnumerable<string> RecursiveDepthFirstValues(Node root)
		{
			if (root == null) return new List<string>();
			var leftValues = RecursiveDepthFirstValues(root.left);
			var rightValues = RecursiveDepthFirstValues(root.right);

			var result = new List<string>();
			result.Add(root.value);
			
			foreach(var val in leftValues)
			{
				result.Add(val);
			}

			foreach (var val in rightValues)
			{
				result.Add(val);
			}

			return result;
		}

		// iterative version
		public List<string> BreadthFirstValues(Node root)
		{
			if (root == null) return new List<string>();
			var result = new List<string>();
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			while(queue.Count > 0)
			{
				var current = queue.Dequeue();
				result.Add(current.value);

				if (current.left != null) queue.Enqueue(current.left);
				if (current.right != null) queue.Enqueue(current.right);
			}

			return result;
		}

		// iterative version
		public bool TreeIncludes(Node root, string target)
		{
			if (root == null) return false;

			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			while(queue.Count > 0)
			{
				var current = queue.Dequeue();

				if (current.value == target) return true;
				if (current.left != null) queue.Enqueue(current.left);
				if (current.right != null) queue.Enqueue(current.right);
			}

			return false;
		}

		// recursive version
		public bool RecursiveTreeIncludes(Node root, string target)
		{
			if (root == null) return false;
			if (root.value == target) return true;
			return (RecursiveTreeIncludes(root.left, target) || RecursiveTreeIncludes(root.right, target));
		}

		// iterative version
		public int TreeSumDepthFirst(Node root)
		{
			if (root == null) return 0;
			Stack<Node> stack = new Stack<Node>();
			stack.Push(root);

			var sum = 0;

			while(stack.Count > 0)
			{
				var current = stack.Pop();
				sum += current.value;

				if (current.right != null) stack.Push(current.right);
				if (current.left != null) stack.Push(current.left);
			}

			return sum;
		}

		// iterative version breadthfirst
		public int TreeSumBreadthFirst(Node root)
		{
			if (root == null) return 0;
			Queue<Node> queue = new Queue<Node>();
			queue.Enqueue(root);

			var sum = 0;

			while(queue.Count > 0)
			{
				var current = queue.Dequeue();
				sum += current.value;

				if (current.left != null) queue.Enqueue(current.left);
				if (current.right != null) queue.Enqueue(current.right);
			}

			return sum;
		}

		// iterative version
		public int TreeSumRecursive(Node root)
		{
			if (root == null) return 0;
			return root.value + TreeSumRecursive(root.left) + TreeSumRecursive(root.right);
		}

		// itertive version depth first
		public int TreeMin(Node root)
		{
			if (root == null) return 0;

			Stack<Node> stack = new Stack<Node>();
			stack.Push(root);

			var minValue = root.value;

			while(stack.Count > 0)
			{
				var current = stack.Pop();

				minValue = current.value < minValue ? current.value : minValue;

				if (current.right != null) stack.Push(current.right);
				if (current.left != null) stack.Push(current.left);
			}

			return minValue;
		}
	}
}
