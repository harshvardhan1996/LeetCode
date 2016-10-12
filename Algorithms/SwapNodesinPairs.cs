// Source : https://leetcode.com/problems/swap-nodes-in-pairs/ 
// Author : codeyu 
// Date : 2016年10月11日 16:50:33 

/**********************************************************************************
*
* 
* Given a linked list, swap every two adjacent nodes and return its head.
* 
* 
* 
* For example,
* Given 1->2->3->4, you should return the list as 2->1->4->3.
* 
* 
* 
* Your algorithm should use only constant space. You may not modify the values in the list, only nodes itself can be changed.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
    public class Solution024 
    {
        public static ListNode<int> SwapPairs(ListNode<int> head) 
        {
            var dummy = new ListNode<int>(0);
            dummy.Next = head;
            head = dummy;
            while(head != null)
            {
                head = SwapNodes(head.Next);
            }
            return dummy.Next;
        }
        static ListNode<int> SwapNodes(ListNode<int> head)
        {
            if(head ==null || head.Next == null)
            {
                return null;
            }
            var tail = head;
            var nextHead = head.Next.Next;
            head = head.Next;
            head.Next = tail;
            tail.Next = nextHead;
            return tail;
        }
    }
}

