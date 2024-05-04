public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0){
            return false;
        }
        string num = x.ToString();
        
        char[] charArray = num.ToCharArray();
        Array.Reverse(charArray);
        string numInvertido = new string(charArray);

        if(numInvertido == num){
            return true;
        }else{
            return false;
        }
    }
}