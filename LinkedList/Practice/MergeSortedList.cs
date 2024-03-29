﻿using LinkedList.SinglyLinkedList;

namespace LinkedList.Practice
{
    internal class MergeSortedList
    {
        /*
         * Merge two sorted linked list
         *  Merging sorted linked list
         *      2 approach:
         *          1. Merging by creating a new list, original lists will not change
         *          2. Merging by rearranging, original list will change
         */

        /// <summary>
        /// Merge two sorted list, original list should not change
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public Node MergeSortedLinkedList(Node list1, Node list2)
        {
            Node startOfMergedList;

            // head of merged list
            if (list1.key <= list2.key)
            {
                startOfMergedList = new Node(list1.key);
                list1 = list1.link;
            }
            else
            {
                startOfMergedList = new Node(list2.key);
                list2 = list2.link;
            }
            // refers to the newly inserted node 
            // will always refers to the last node
            Node currMerge = startOfMergedList;

            while (list1 != null && list1 != null)
            {
                if (list1.key <= list2.key)
                {
                    currMerge.link = new Node(list1.key);
                    list1 = list1.link;
                }
                else
                {
                    currMerge.link = new Node(list2.key);
                    list2 = list2.link;
                }
                currMerge = currMerge.link;
            }

            while (list1 != null)
            {
                currMerge.link = new Node(list1.key);
                list1 = list1.link;
                currMerge = currMerge.link;
            }

            while (list2 != null)
            {
                currMerge.link = new Node(list2.key);
                list2 = list2.link;
                currMerge = currMerge.link;
            }

            return startOfMergedList;
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = list1;
            while(list1 != null && list2 != null)
            {
                if(list1.val >= list2.val)
                {
                    list1.next = new ListNode(list2.val, list1.next);
                    list2 = list2.next;  
                }
                list1 = list1.next;
            }
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
