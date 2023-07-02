namespace BinaryTree.BinaryTree
{
    internal class MaximumNode
    {
        /// <summary>
        /// Find the node whose value is maximum in the Binary tree
        /// T: O(N)
        /// S: O(T)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindMaximumNode(Node node)
        {
            if (node == null)
                return int.MinValue;

            return Math.Max(node.info, Math.Max(FindMaximumNode(node.left), FindMaximumNode(node.right)));
        }

       
    }
}
