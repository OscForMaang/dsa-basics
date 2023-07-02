using System.Net.Security;

namespace LinkedList.SinglyLinkedList
{
    /// <summary>
    /// Circular Linked list implementation
    /// </summary>
    internal class CircularLinkedList
    {
        private Node last;

        public CircularLinkedList()
        {
                last = null;
        }

        /// <summary>
        /// Traversal of circular linked list
        /// </summary>
        public void DisplayList()
        {
            if(last == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node current = last.link;


            // we are using do while loop because we need a terminating condition 
            do
            {
                Console.WriteLine(current.key + " ");
                current = current.link;
            } while (current != last.link);
            Console.WriteLine();
        }


        /// <summary>
        /// Insert a node with value key at the beginning of the circular linked list
        /// </summary>
        /// <param name="key"></param>
        public void InsertInBeginning(int key)
        {
            Node newNode = new Node(key);

            newNode.link = last.link;
            last.link = newNode;
        }
    }
}
