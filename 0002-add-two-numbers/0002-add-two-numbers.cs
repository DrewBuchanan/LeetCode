/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode output = null;
        ListNode parent = null;
        bool increment = false;
        while (l1 != null || l2 != null)
        {
            int val = (l1?.val ?? 0) + (l2?.val ?? 0) + (increment ? 1 : 0);
            increment = false;
            if (val >= 10)
            {
                increment = true;
                val -= 10;
            }

            ListNode node = new ListNode(val, null);
            if (output == null)
            {
                output = node;
            }
            else
            {
                parent.next = node;
            }

            l1 = l1?.next ?? null;
            l2 = l2?.next ?? null;
            parent = node;
        }
        
        if (increment)
		{
            parent.next = new ListNode(1);
		}

        return output;
    }
    
    public ListNode ReverseListNode(ListNode head)
    {
        ListNode previous, current, following;
        previous = null;
        current = head;
        following = head;
        
        while (current != null)
        {
            following = following.next;
            current.next = previous;
            previous = current;
            current = following;
        }
        
        return previous;
    }
}