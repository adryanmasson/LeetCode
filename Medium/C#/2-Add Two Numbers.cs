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

    public string Verificar(ListNode l, string n = ""){

        if(l != null){
            n = Verificar(l.next);
            n += (l.val).ToString();
            return n;
        }

        return null;

    }

    public ListNode CriarNode(string n){
        

        if(n != ""){
            int a = n[0] - '0';
            string b = n.Remove(0, 1);
            ListNode l = new ListNode(a, CriarNode(b));
            return l;
        }

        return null;

    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string n1 = Verificar(l1);
        string n2 = Verificar(l2);

        string soma = (BigInteger.Parse(n1) + BigInteger.Parse(n2)).ToString();
        char[] somaCharArray = soma.ToCharArray();
        Array.Reverse(somaCharArray);
        string newSoma = new string(somaCharArray);
        


        return CriarNode(newSoma);

    }
}