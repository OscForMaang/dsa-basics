using System.Text;

namespace BinaryTree.Practics
{
    internal class LeafSimilarproblem
    {
        public bool LeafSimilar(Node root1, Node root2)
        {
            void Inorder(Node node, List<int> leaf)
            {
                if (node == null)
                    return;
                if (node.Left == null && node.Right == null)
                    leaf.Add(node.Value);

                Inorder(node.Left, leaf);
                Inorder(node.Right, leaf);
            }
            List<int> leaf = new List<int>();
            List<int> leaf2 = new List<int>();
            Inorder(root1, leaf);
            Inorder(root2, leaf2);
            return Enumerable.SequenceEqual(leaf, leaf2);
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
