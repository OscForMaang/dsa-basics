namespace BinaryTree.Practics
{
    internal class DFSTreeTraversal
    {
        private int diameter = 0;
        public int Daimeter(Node root)
        {
            // Left : Right : Node => Post order traversal

            Height(root);
            return diameter-1;

        }

        private int Height(Node root)
        {
            if (root == null)
                return 0;
            int leftH = Height(root.Left);
            int rightH = Height(root.Right);
            diameter = Math.Max(diameter, leftH + rightH  + 1);
            return Math.Max(leftH, rightH) + 1;
        }

        public Node InvertBinaryTree(Node root)
        {
            if(root == null)
                return null;
            Node left = InvertBinaryTree(root.Left);
            Node right = InvertBinaryTree(root.Right);
            root.Left = right;
            right.Right = left;
            return root;
        }

        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value;
            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}
