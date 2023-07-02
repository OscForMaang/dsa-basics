namespace BinarySearchTree.BST
{
    internal class BinarySearchTreeInsertion
    {
        /*
         * A new node with key x has to be inserted
         * Start at the root node and move down the tree
         * if x < key : Move left
         * if x > key : Mode right
         * if x = key : Duplicate key
         * if we reach A NULL left child or NULL right child : Insertion
         */

        /// <summary>
        /// Iterative solution: Insert a node with value key in a binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node Insert(Node root, int key)
        {
            Node curr = root;
            Node newNode = new Node(key);
            Node par = null;

            while (curr != null)
            {
                par = curr;
                if (key < curr.info)
                    curr = curr.left;
                else if (key > curr.info)
                    curr = curr.right;
                else
                {
                    Console.WriteLine($"{key} is not present in the tree");
                }
            }

            if(par == null)
                root = newNode;
            else if(key < par.info)
                par.left = newNode;
            else
                par.right = newNode;

            return root;
        }
        /// <summary>
        /// Recursive solution: Insert a node with value key in a binary search tree
        /// </summary>
        /// <param name="node"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public Node InsertRecursive(Node node, int key)
        {
            if (node == null)
                node = new Node(key);
            else if(key < node.info)
                node.left = InsertRecursive(node.left, key);
            else if(key > node.info)
                node.right = InsertRecursive(node.right, key);
            else
                Console.WriteLine($"{key} is not present in the tree");

            return node;
        }
    }
}
