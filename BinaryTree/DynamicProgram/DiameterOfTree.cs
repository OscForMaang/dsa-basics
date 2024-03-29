namespace BinaryTree.DynamicProgram
{
    internal class DiameterOfTree
    {
        int diameter = 0;
        public int FindDiameter(TreeNode root)
        {
            if(root == null)
                return 0;

            int left = FindDiameter(root.left);
            int right = FindDiameter(root.right);
            diameter = Math.Max(diameter, left + right + 1);

            return Math.Max(left, right) + 1;
        }
    }
}
