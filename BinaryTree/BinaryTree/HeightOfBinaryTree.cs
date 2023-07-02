namespace BinaryTree.BinaryTree
{
    internal class HeightOfBinaryTree
    {
        public int GetHeightOfBinaryTree(Node root)
        {
            if (root == null)
                return int.MinValue;
           
            return Math.Max(GetHeightOfBinaryTree(root.left), GetHeightOfBinaryTree(root.right)) + 1;
        }
    }
}
