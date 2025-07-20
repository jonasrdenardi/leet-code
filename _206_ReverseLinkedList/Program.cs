using _206_ReverseLinkedList;

// head = [1,2,3,4,5]
var node5 = new ListNode(5);
var node4 = new ListNode(4, node5);
var node3 = new ListNode(3, node4);
var node2 = new ListNode(2, node3);
var node1 = new ListNode(1, node2);

var resp = ReverseList(node1);
Console.WriteLine(resp);

ListNode ReverseList(ListNode head)
{
    ListNode prev = null;
    ListNode current = head;

    while (current != null)
    {
        var next = current.next; // save the next
        current.next = prev; // invert the pointer
        prev = current; // advance prev
        current = next; // advance next
    }

    return prev;
}