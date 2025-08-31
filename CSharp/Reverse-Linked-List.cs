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
	var nodes = new List<ListNode>(10);
	while (head != null)
	{
		nodes.Add(head);
        head = head.next;
	}

	if (nodes.Count == 0)
		return head;

	for (int i = nodes.Count - 1; i >= 1; i--)
	{
		nodes[i].next = nodes[i - 1];
	}
	nodes[0].next = null;
	return nodes[^1];
    }
}