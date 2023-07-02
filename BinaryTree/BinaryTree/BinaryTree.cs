namespace BinaryTree.BinaryTree
{
    /// <summary>
    /// Binary Tree implementations
    /// </summary>
    internal class BinaryTree
    {
        /*
            Traversal : Visiting the root node, Traversing its left subtree, Traversing its right subtree
                        R L N
            Preorder : NLR 
            In order : LNR
            Post order : LRN
            
         */

        Node root;
        public BinaryTree()
        {
            root = null;
        }


        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        private void PreOrder(Node node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.info + " ");
            PreOrder(node.left) ;
            PreOrder(node.right);
        }


        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }

        private void InOrder(Node node)
        {
            if (node == null)
                return;
            InOrder(node.left);
            Console.WriteLine(node.info + " ");
            InOrder(node.right);
        }

        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        private void PostOrder(Node node)
        {
            if (node == null)
                return;
            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine(node.info + " ");
        }

        public void LevelOrderUsingQu()
        {
            
        }
    }
}
