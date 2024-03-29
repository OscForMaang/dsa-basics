namespace BinaryTree.Practics
{
    internal class NodeInfection
    {
        public int AmountOfTime(TreeNode root, int start)
        {
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            void BuildGraph(TreeNode node)
            {
                if(node == null)
                    return;

                if(node.left != null)
                {
                    if (adjList.ContainsKey(node.val))
                    {
                        adjList[node.val].Add(node.left.val);
                    }
                    else
                    {
                        adjList[node.val] = new List<int>()
                        {
                            node.left.val

                        };
                    }

                    if (adjList.ContainsKey(node.left.val))
                    {
                        adjList[node.left.val].Add(node.val);
                    }
                    else
                    {
                        adjList[node.left.val] = new List<int>()
                        {
                            node.val

                        };
                    }
                }

                if (node.right != null)
                {
                    if (adjList.ContainsKey(node.val))
                    {
                        adjList[node.val].Add(node.right.val);
                    }
                    else
                    {
                        adjList[node.val] = new List<int>()
                        {
                            node.right.val

                        };
                    }
                    if (adjList.ContainsKey(node.right.val))
                    {
                        adjList[node.right.val].Add(node.val);
                    }
                    else
                    {
                        adjList[node.right.val] = new List<int>()
                        {
                            node.val
                        };
                    }
                }
                BuildGraph(node.left);
                BuildGraph(node.right);
            }
            HashSet<int> visisted = new HashSet<int>();
            int time = 0;
            void BFS()
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(start);
                visisted.Add(start);
                while (queue.Count > 0)
                {
                    int level = queue.Count;
                    for (int i = 0; i < level; i++)
                    {
                        int currentNode = queue.Dequeue();
                        foreach (int neighbor in adjList[currentNode])
                        {
                            if (!visisted.Contains(neighbor))
                            {
                                queue.Enqueue(neighbor);
                                visisted.Add(neighbor);
                            }
                        }
                    }
                    time++;
                }
            }
            BuildGraph(root);
            BFS();
            return time;
        }


        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

    }
}
