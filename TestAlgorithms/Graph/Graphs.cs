using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithms.Graph
{
	public class Graphs
	{
		// iterative depth first graph
		public void DepthFirst(Dictionary<string, string[]> graph, string source)
		{
			Stack<string> stack = new Stack<string>();
			stack.Push(source);

			while(stack.Count > 0)
			{
				var current = stack.Pop();
				Console.WriteLine(current);

				foreach (var neigbhor in graph[current])
				{
					stack.Push(neigbhor);
				}
			}
		}

		// recursive depth first 
		public void RecursiveDepthFirst(Dictionary<string, string[]> graph, string source)
		{
			Console.WriteLine(source);
			foreach (var neigbhor in graph[source])
			{
				RecursiveDepthFirst(graph, neigbhor);
			}
		}

		// iterative depth first graph
		public void BreadthFirst(Dictionary<string, string[]> graph, string source)
		{
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(source);

			while (queue.Count > 0)
			{
				var current = queue.Dequeue();
				Console.WriteLine(current);

				foreach (var neigbhor in graph[current])
				{
					queue.Enqueue(neigbhor);
				}
			}
		}

		// recursive solution
		public bool HasPath(Dictionary<string, string[]> graph, string source, string destination)
		{
			if (source == destination) return true;

			foreach (var neighbor in graph[source])
			{
				if (HasPath(graph, neighbor, destination)) return true;
			}

			return false;
		}

		// iterative breadth first
		public bool HasPathBreadthFirst(Dictionary<string, string[]> graph, string source, string destination)
		{
			Queue<string> queue = new Queue<string>();
			queue.Enqueue(source);

			while(queue.Count > 0)
			{
				var current = queue.Dequeue();

				if (current == destination) return true;

				foreach (var neightbor in graph[current])
				{
					queue.Enqueue(neightbor);
				}
			}

			return false;
		}
	}
}
