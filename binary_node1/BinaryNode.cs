namespace binary_node1
{
	class BinaryNode<T>
	{
		T Value;
		BinaryNode<T>? LeftChild;
		BinaryNode<T>? RightChild;

		public BinaryNode(T value)
		{
			Value = value;
			LeftChild = null;
			RightChild = null;
		}

		public void AddLeft(BinaryNode<T> leftNode)
		{
			LeftChild = leftNode;
		}

		public void AddRight(BinaryNode<T> rightNode)
		{
			RightChild = rightNode;
		}

		public override string ToString()
		{
			if (LeftChild is null && RightChild is null)
			{
				return $"{Value}: null null";
			}

			if (LeftChild is null)
			{
				return $"{Value}: null {RightChild.Value}";
			}

			if (RightChild is null)
			{
				return $"{Value}: {LeftChild.Value} null";
			}

			return $"{Value}: {LeftChild.Value} {RightChild.Value}";
		}
	}
}
