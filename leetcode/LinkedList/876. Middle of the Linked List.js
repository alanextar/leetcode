/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var middleNode = function(head) {
    let nodesCount = 0;
    const nodesArr = [];
    let curNode = head;

    while(curNode != null)
    {
      nodesArr.push(curNode);
      nodesCount++;
      curNode = curNode.next;
    }

    return nodesArr[Math.floor(nodesCount/2)];
};