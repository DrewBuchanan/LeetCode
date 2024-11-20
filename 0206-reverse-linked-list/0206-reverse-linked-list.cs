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
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null, current, following;
        
        current = head;
        following = head;
        
        while (current != null) {
            following = following.next;
            current.next = previous;
            previous = current;
            current = following;
        }
        
        return previous;
    }
}