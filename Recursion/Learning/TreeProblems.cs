namespace Recursion.Learning
{
    public class TreeProblems
    {

        public int Height(Node root) // Hypothesis: return height of tree from root node
        {
            //  Base condition: if root is null, height of tree = 0
            if (root == null)
                return 0;

            int leftHeight = Height(root.left); // Hypothesis : returns height of left sub tree
            int rightHeight = Height(root.right); // Hypothesis : returns height of right sub tree

            // Induction steps: Height of root node = 1 + Max(left,right)

            return 1 + Math.Max(leftHeight, rightHeight);
        }

        // Node of a binary tree
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }
    }
}
