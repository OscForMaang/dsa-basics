namespace BinaryTree.Practics
{
    internal class NextRightPointers
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public class Solution
        {
            public Node Connect(Node root)
            {
                if (root == null)
                    return root;

                Node node = root;
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(node);
                while (queue.Any())
                {
                    int levelLength = queue.Count;
                    Node right = null;
                    for(int i = 0; i < levelLength; i++)
                    {
                        Node curr = queue.Dequeue();
                        curr.next = right;
                        right = curr;
                        if(curr.right != null)
                        {
                            queue.Enqueue(curr.right);
                            queue.Enqueue(curr.left);  
                        }
                    }
                }
                return root;
            }

            /// <summary>
            /// without using extra space
            /// </summary>
            /// <param name="root"></param>
            /// <returns></returns>
            public Node ConnectSolution2(Node root)
            {
                if (root == null)
                    return root;

                Node leftMost = root;
                while(leftMost.left != null)
                {
                    Node curr = leftMost;
                    while(curr != null)
                    {
                        curr.left.next = curr.right;
                        if(curr.next != null)
                        {
                            curr.right.next = curr.next.left;
                        }
                        curr = curr.next;
                    }
                    leftMost = leftMost.left;   
                }
                return root;
            }
        }
    }
}
