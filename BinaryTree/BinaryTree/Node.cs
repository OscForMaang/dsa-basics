namespace BinaryTree.BinaryTree
{

    /*

        A Binary tree is a finite set of nodes that is 
            1. Either empty or
            2. Consists of a distinguished node known as root and remaining nodes are partitioned into two disjoint sets T1 and T2 and both of them are binary trees. T1 is called left subtree and T2 is called subtree.


        Property 1: In a binary tree, maximum number of nodes on any level i is 2^i, where i >= 0
        Property 2: In a binary tree of height h, maximum number of nodes possible is 2^h - 1
        Property 3: In a binary tree of height h, minimum number of nodes possible is h, (A binary tree with number of node equals to h is called skew tree)
        Property 4: For a binary tree with n nodes, Maximum height possible is n and Minimum height possible is |log(n+1)|, here log is of base 2
        Property 5: In a non empty binary tree, if n = number of nodes and e = number of edge then e = n-1
        Property 6: In a non empty binary tree, if a = number of nodes with no child and b = number of nodes with 2 children then a = b + 1
        Strictly Binary Tree : A Binary tree in which each node is either a leaf node or has two children
            => A strictly binary tree with n leaf nodes has n-1 non leaf nodes
            => A strictly tree with n leaf nodes has total 2n-1 nodes
        Extended Binary Tree : In a binary tree, if each subtree is replaced by a special node then the resulting tree is extended binary tree or 2-tree
            => 
        Property 7: In an extended binary tree, if E is the external path length, I is the internal path length and n is the number if internal nodes, E = I + 2n 

        Full Binary Tree : A Binary tree in which each level has maximum number of nodes, If h is the height of tree, it will have 2^h - 1 nodes
        Complete Binary Tree: All level have maximum number of nodes except possibly the last level, In the last level, number of nodes range from 1 to 2^h-1 and all these are towards the left.
            Height =  |log(n+1)|

     */

    /// <summary>
    /// Node of a binary Tree 
    /// </summary>
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
