
namespace BinarySearchTree.BST
{
    internal class Node
    {
        public Node left;
        public int info;
        public Node right;

        public Node(int ch)
        {
            info = ch;
            left = null;
            right = null;
        }
    }
}
