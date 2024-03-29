namespace BinaryTree.Practics
{

    public class BinaryTree
    {
        public BinaryTree()
        {

        }

        private BinaryTreeNode root;

        public void Populate()
        {
            Console.WriteLine("Enter the root node : ");
            int value = Convert.ToInt32(Console.ReadLine());
            root = new BinaryTreeNode(value);
            Populate(root);
        }

        private void Populate(BinaryTreeNode node)
        {
            Console.WriteLine("Do you want to enter left of " + node.Value);
            bool left = Convert.ToBoolean(Console.ReadLine());
            if (left)
            {
                Console.WriteLine("Enter the value of the left of " + node.Value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.Left = new BinaryTreeNode(value);
                Populate(root.Left);
            }

            Console.WriteLine("Do you want to enter right of " + node.Value);
            bool right = Convert.ToBoolean(Console.ReadLine());
            if (right)
            {
                Console.WriteLine("Enter the value of the right of " + node.Value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.Right = new BinaryTreeNode(value);
                Populate(root.Right);
            }
        }

        public void Display()
        {
            Display(root, " ");
        }

        private void Display(BinaryTreeNode node, string indent)
        {
            if (node == null)
                return;

            Console.WriteLine(indent + node.Value);
            Display(node.Left, indent + '\t');
            Display(node.Right, indent + '\t');
        }
    }
    /// <summary>
    /// Binary tree node
    /// </summary>
    public class BinaryTreeNode
    {
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public int Value { get; set; }

        public BinaryTreeNode(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;  
        }
    }
}
