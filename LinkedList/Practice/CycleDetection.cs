using LinkedList.SinglyLinkedList;

namespace LinkedList.Practice
{
    internal class CycleDetection
    {
        /// <summary>
        /// check if the given linked list has cycle into
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsCyclePresent(Node head)
        {
            // Fast and slow pointer approach;

            Node fast = head;
            Node slow = head;

            while(fast != null && fast.link != null) { 
                if(fast == slow) 
                    return true; // cycle detected

                fast = fast.link.link; 
                slow = slow.link;
            }
            return false;
        }

        public int LengthOfCycle(Node head)
        {
            // Fast and slow pointer approach;

            Node fast = head;
            Node slow = head;

            while (fast != null && fast.link != null)
            {
                if (fast == slow) // cycle found
                {
                    int length = 0;
                    do
                    {
                        slow = slow.link;
                        length++;
                    } while (fast != slow);

                    return length;
                }

                fast = fast.link.link;
                slow = slow.link;
            }

            return 0;
        }
    }
}
