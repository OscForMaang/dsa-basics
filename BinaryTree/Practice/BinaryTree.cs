namespace BinaryTree.Practice
{
    public class BinaryTree
    {
        /*
         * GOAL : Implement complete Binary Tree
         */

        Node root;
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Create a Binary Tree, User will give the input during run time
        /// User will add the node from left to right
        /// </summary>
        /// <returns></returns>
        public Node CreateBinaryTree() {
            Console.WriteLine($"Enter -1, if you wish to stop adding node to the tree");

            int value = Convert.ToInt32(Console.ReadLine());
            if (value == -1)
                return null;

            Node newNode = new Node(value);
            Console.WriteLine($"Enter Left child of {value}");
            newNode.left = CreateBinaryTree();
            Console.WriteLine($"Enter Right child of {value}");
            newNode.right = CreateBinaryTree();
            return newNode; 
        }


        public void InOrderTraversal(Node node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.left);
            Console.Write($"{node.value} ");
            InOrderTraversal(node.right);
        }
    }

    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int val)
        {
            this.value = val;
            left = null;
            right = null;
        }
    }
}
