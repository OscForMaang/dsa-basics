namespace BinaryTree.BinaryTree
{
    internal class ConstructBinaryTree
    {
        /*
         * Constructing a binary tree from traversal
         * In order and Pre order traversal is given - we can construct a unique binary tree
         * In order and Post order traversal is given - we can construct a unique binary tree
         * Pre order and post order traversal is given - we can't construct a unique binary tree because 2 different tree can have same pre and post order traversal
         */

        /// <summary>
        /// Preorder Traversal: First Node is the root node
        /// Remaining nodes- Left subtree and right subtree
        /// In order nodes- Root node is in between nodes of left subtree and nodes of right subtree
        /// Follow same procedure for all subtrees
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public Node ConstructBinaryTreeFromInorderAndPreorderTraversal(List<int> inorder, List<int> preorder)
        {
            return null;
        }
    }
}
