using LinkedList.SinglyLinkedList;

namespace LinkedList.Practice
{
    internal class InsertElement
    {
        // Here we will use recursion to Add element in the Link list
        /*
         * 1. Void return type & make changes in LinkedList
         * 2. Node return type that return the list node to change the structure
         */

        public void Insert(Node head, int value, int index)
        {
            Node curr = head;
            InsertAtIndex(curr, value, index);
        }

        private void InsertAtIndex(Node node, int value, int index) {
            
            if(index == 0)
            {
                Node newNode = new Node(value);
                newNode.link = node.link;
                node.link = newNode;
                return;
            }

            InsertAtIndex(node.link, value, index--);
        }
    }
}
