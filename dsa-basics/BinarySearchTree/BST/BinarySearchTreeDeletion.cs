namespace BinarySearchTree.BST
{
    internal class BinarySearchTreeDeletion
    {
        /*
         * Deletion in a Binary search tree
         * 1. Node has no child : Leaf Node
         *      For deleting a leaf node N 
         *          Link to node N in it's parent is replaced by null
         *          If N is left child ---> Left child of parent becomes null
         *          If N is right child ---> Right child of parent becomes null
         * 2. Node has exactly 1 child 
         *      After deletion, single child will come at the place of deleted node
         *      P  : Node to be deleted 
         *      PR : Parent of the node that has to be deleted
         *      CH : Child of the node that has to be deleted
         *      If P is left node of the PR: CH becomes left child of PR
         *      If P is right node of the PR: CH becomes right child of the PR
         * 3. Node has exactly 2 child 
         *      Find the in order successor of the node to be deleted
         *          In order successor of N : Left most node in the right subtree of N
         *      Copy the date of the in order successor to the node
         *      Delete the in order successor from the tree
         */

        /// <summary>
        /// Delete a node with value key from Binary search tree
        /// </summary>
        /// <param name="root"></param>
        /// <param name="key"></param>
        public void Delete(Node root, int key)
        {
            Node p = root;
            Node par = null;


            // Find the node which has to be deleted
            while (p != null)
            {
                if (key == p.info)
                    break;
                par = p;

                if (key < p.info)
                    p = p.left;
                else
                    p = p.right;
            }

            if(p == null)
            {
                Console.WriteLine($"{key} not found");
                return;
            }

            // Case 3: Node has 2 children

            Node s, ps;
            if(p.left != null && p.right != null) {
                ps = p;
                s= p.right;

                while(s.left != null)
                {
                    ps = s;
                    s = s.left;
                }

                p.info = s.info;
                p = s;
                par = ps;
            
            }

            // case 1 and 2: 1 or No Child

            Node ch;
            if(p.left != null) // Node to be deleted has left child 
                ch = p.left;
            else                // node to be deleted has right child or no child
                ch = p.right;

            if (par == null)  // node to be deleted is root node
                root = ch;
            else if (p == par.left) // node is left child of its parent
                par.left = ch;
            else
                par.right = ch; // node is right child of its parent

        }

    }
}
