namespace LinkedList.Practice
{
    public class MergeSort
    {
        public Node GetMiddleNode(Node head)
        {
            Node fast = head;
            Node slow = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public Node MergeSortedList(Node list1, Node list2)
        {
            Node startOfMergedList;

            // head of merged list
            if (list1.val <= list2.val)
            {
                startOfMergedList = new Node(list1.val);
                list1 = list1.next;
            }
            else
            {
                startOfMergedList = new Node(list2.val);
                list2 = list2.next;
            }
            // refers to the newly inserted node 
            // will always refers to the last node
            Node currMerge = startOfMergedList;
                
            while (list1 != null && list1 != null)
            {
                if (list1.val <= list2.val)
                {
                    currMerge.next = new Node(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    currMerge.next = new Node(list2.val);
                    list2 = list2.next;
                }
                currMerge = currMerge.next;
            }

            while (list1 != null)
            {
                currMerge.next = new Node(list1.val);
                list1 = list1.next;
                currMerge = currMerge.next;
            }

            while (list2 != null)
            {
                currMerge.next = new Node(list2.val);
                list2 = list2.next;
                currMerge = currMerge.next;
            }
            return startOfMergedList;
        }

        /// <summary>
        /// Sort list using merge sort technique
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>

        public Node SortList(Node head)
        {
            if (head == null | head.next == null)
                return head;

            Node mid = GetMiddleNode(head);
            Node left = SortList(head);
            Node right = SortList(mid);

            return MergeSortedList(left, right);
        }

        public class Node
        {
            public int val;
            public Node next;
            public Node(int val)
            {
                this.val = val;
                this.next = null;
            }
        }
    }
}
