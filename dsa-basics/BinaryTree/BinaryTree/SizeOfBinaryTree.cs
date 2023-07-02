namespace BinaryTree.BinaryTree
{
    internal class SizeOfBinaryTree
    {
        /// <summary>
        /// Total number of nodes in Binary Tree 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int FindNumberOfNodes(Node node)
        {
            if(node == null)
                return 0;
            return FindNumberOfNodes(node.left)  + FindNumberOfNodes(node.right) + 1;
        }
    }
}
