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
    public ListNode MiddleNode(ListNode head) {
	var values = new List<ListNode>();
	while (head != null)
	{
		values.Add(head);
		head = head.next;
	}

	return values[values.Count / 2];        
    }
}