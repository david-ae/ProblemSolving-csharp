using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAlgorithms.BinaryTree
{
	public class Node
	{
		public dynamic value;
		public Node left;
		public Node right;

		public Node(dynamic value)
		{
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}
}
