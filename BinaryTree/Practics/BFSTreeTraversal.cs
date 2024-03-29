namespace BinaryTree.Practics
{

    /// <summary>
    /// When to use BFS Or Level order traversal
    /// 1. When answer liles near root node
    /// 2. When you are asked to search by level
    /// </summary>
    internal class BFSTreeTraversal
    {
        public IList<IList<int>> ZigZag(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

           LinkedList<Node> deque = new LinkedList<Node>();
           deque.AddFirst(root);
           bool IsReverse = false;

            while (deque.Any())
            {
                int levelSize = deque.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < levelSize; i++)
                {
                   
                    if (!IsReverse)
                    {
                        Node node = deque.First();
                        deque.RemoveFirst();
                        if (node.Left != null)
                        {
                          deque.AddLast(node.Left);
                        }
                        if (node.Right != null)
                        {
                            deque.AddLast(node.Right);
                        }
                    }
                    else
                    {
                        Node node = deque.Last();
                        deque.RemoveLast();
                        if (node.Right != null)
                        {
                            deque.AddFirst(node.Right);
                        }
                        if (node.Left != null)
                        {
                            deque.AddFirst(node.Left);
                        }
                       
                    }
                }
                IsReverse = !IsReverse;
                result.Add(level);
            }

            return result;

        }

        public IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int levelSize = queue.Count;
                List<int> level = new List<int>();
                for (int i = 0; i < levelSize; i++)
                {
                    Node node = queue.Dequeue();
                    level.Add(node.Value);
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                    }
                }
                result.Add(level);
            }
            return result;
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
