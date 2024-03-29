namespace BinaryTree.Practics
{
    public class BST
    {
        Node root;  
        public BST()
        {
            root = null;
        }


        public void Insert(int value)
        {
            root = Insert(value, root);
        }

        /// <summary>
        /// Insert element in binary search tree
        /// </summary>
        /// <param name="value"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node Insert(int value, Node node)
        {
            if(node == null)
            {
                node = new Node(value);
                return node;
            }

            if(value < node.Value)
                node.Left = Insert(value, node.Left);
            else
                node.Right = Insert(value, node.Right);

            node.Height = Math.Max(Height(node.Left), Height(node.Right)) + 1;
            return node; 
        }

        /// <summary>
        /// Height
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Height(Node node)
        {
            if(node == null)
                return -1;

            return node.Height;
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void Display()
        {
            Display(root, "Root Node: ");
        }

        private void Display(Node node, string details)
        {
            if (node == null)
                return;
            Console.WriteLine(details + node.GetValue());
            Display(node.Left, $"Left child of { node.GetValue()} : ");
            Display(node.Right, $"Right child of {node.GetValue()} : ");
        } 

        public bool IsBalanced()
        {
            return IsBalanced(root);
        }

        private bool IsBalanced(Node node)
        {
            return (node == null) ||
                (Math.Abs(Height(node.Left) - Height(node.Right)) <= 1
                && IsBalanced(node.Left) && IsBalanced(node.Right));
        }

        public void Populate(int[] nums)
        {
            foreach (int num in nums)
                Insert(num);
        }

        #region
        public class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Value { get; set; }
            public int Height { get; set; }
            public Node(int value)
            {
                this.Value = value;
            }

            public int GetValue()
            {
                return this.Value;
            }
        }
        #endregion
    }
}
