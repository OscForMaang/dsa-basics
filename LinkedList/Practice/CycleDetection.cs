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

        public int FindDuplicate(int[] nums)
        {
            int slow = 0;
            int fast = 0;

            while (true)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (slow == fast)
                    break;
            }

            int slow2 = 0;
            while (true)
            {
                slow = nums[slow];
                slow2 = nums[slow2];
                if (slow == slow2)
                    break;
            }

            return slow;
        }
    }
}
