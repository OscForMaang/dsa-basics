/*
 * Szie : totol number of node
 * Parent / Child node
 * leaf node
 * sibling nodes
 * Height of tree : maxinum number of edge from root to farthest leaf node
 * Level : height of root - height of node
 * Degree : 0, 1, 2
 * root level : 0
 *                    0  -------------Level 0
 *                1       2 ----------Level 1
 *              3    4  5    6 -------Level 2
 *           7    8            -------Level 3
 *           
 *Types of Binary Tree
 *  Complete Binary Tree : All the levels of the node would be filled apart from last level but last
 *      level is full from left to right  
 * 
 * Full Binary Tree or Strict Binary Tree
 *      Each node have either zero childern or two children
 *      Used in compression
 * 
 * Perfect Binary Tree : All the internal nodes has 2 children and all the leaf nodes are at same level
 * 
 * Height balanced Binary Tree : AVL / Red & Black
 *  Avg Height : O(LogN)
 *  
 *  Skewed Binary Tree
 *      Height : O(N)
 *   
 *  Ordered Binary Tree
 *      Binary search Tree : Every node has one some property
 *      
 * Properties:
 *  1. Total Number of Nodes in Perfect Binary Tree
 *          Total Nodes = 2 ^ ( n+1 ) - 1=> Maxinum number of nodes a tree can have
 *  2. Total number of Leaf node in Perfect Binary Tree :   2^h
 *  
 *  3. Total number of Internal node in Perfect BT = 2^h - 1
 *  
 *  4. N = Numbers of leaves : Minimum number of level = Log(N + 1)
 *  
 *  5. For strict Binart Tree
 *      N = Leaf Nodes
 *      Number of internal nodes = N - 1
 *      No. Of leaf nodes = No of internal nodoes + 1
 * 
 * 6. Number of leaf nodes = 1 + Number of internal nodes with 2 childeren(not including root)   
 */

using System.Text;

bool ArrayStringsAreEqual(string[] word1, string[] word2)
{

    string str1 = String.Join(string.Empty, word1);
    string str2 = String.Join(string.Empty, word2);
    return str1 == str2;
}