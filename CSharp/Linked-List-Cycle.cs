/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
	var visited = new Dictionary<ListNode,bool>();

	while (head is not null)
	{
		if (!visited.TryAdd(head,true))
			return true;
		head = head.next;
	}
	return false;
    }
}