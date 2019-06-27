/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if(head ==null)
        {
            return head;
        }
        ListNode oddHead = head;
        ListNode evenHead = head.next;
        ListNode evenHeadReal = head.next;
        while(evenHead!=null && evenHead.next!=null)
        {
            oddHead.next = evenHead.next;
            oddHead  = oddHead.next;
            evenHead.next = oddHead.next;
            evenHead = evenHead.next;
        }
        oddHead.next = evenHeadReal;
        return head;
    }
}