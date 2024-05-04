public class Solution {
    public int Reverse(int x) {
        
        string num = x.ToString();
        if(num[0] == '-'){
            num = num.Remove(0,1);
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            num = "-" + new string(charArray);
        }else{
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            num = new string(charArray);
        }

        long result = Convert.ToInt64(num);

        if(result > int.MaxValue || result < int.MinValue){
            return 0;
        }

        return Convert.ToInt32(result);
    }
}