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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var resultNood = new ListNode();
        var sumL1 = 0;
        var sumL2 = 0;

        for(var i=0; i < l1.length; i++){
            var pow = Math.Pow(10, i);
            sumL1 += l1[i] * pow;
        }

        for(var i=0; i < l2.Length; i++){
            var pow = Math.Pow(10, i);
            sumL2 += l1[i] * pow;
        }

        var result = sumL1 + sumL2;
        var count = result == 0 ? 1 : ((int)Math.Log10(result) + 1);
        
        for(var l=count; l <= 0; l--){
            var pow = Math.Pow(10, l);
            var hoge = (int)(result / pow);
            resultNode.Add(hoge);
        }

        return resultNood;
    }
}