using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int pow = 0;
        string res = "";
        
        if(n < 3)
            pow = 0;
        else{
            while(n >= Math.Pow(3, pow + 1)){
            pow++;
            }    
        }
        
        
        for(int i = pow; i >= 0; i--){
            res = res + n / (int)(Math.Pow(3, i));
            n = n % (int)(Math.Pow(3, i));
        }
        
        for(int i = 0; i < res.Length; i++){
            answer = answer + ((int)Math.Pow(3, i) * int.Parse(res.Substring(i, 1)));
        }
        
        return answer;
    }
}